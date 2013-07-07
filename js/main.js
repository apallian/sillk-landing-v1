/**
* Alert Shake is a jQuery validation plugin that shakes pieces of a form that did not validate
* similar to Apple's MacBook login screen.
* \version 1.0
* \author Anna Drazich
* \copyright (c) 2012 Anna Drazich
* Dual licensed under the MIT and GPL licenses.
* MIT License: https://github.com/adrazich/alert-shake-jquery/blob/master/MIT-License.txt
* GPL License: https://github.com/adrazich/alert-shake-jquery/blob/master/GPL-License.txt
* Website: http://www.initanna.com/alert-shake/
* Github: https://github.com/adrazich/alert-shake-jquery
*/
(function (e) {
    function g(a) { for (var c = 0; c < b.length; c++) if (b[c].o == a) { b[c].animating || (animating = !0, e(a).animate({ left: b[c].direction + d.amount + "px" }, d.speed, d.easing, function () { b[c].direction = "-=" == b[c].direction ? "+=" : "-="; b[c].animating = !1; b[c].interval++; b[c].interval >= d.number && e(a).animate({ left: b[c].position + "px" }, d.speed, d.easing, function () { b[c].execute = !1 }) })); break } } var d = _defaults = null, b = [], f = { init: function (a) {
        d = _defaults = e.extend({ easing: "linear", number: 8, speed: 10, amount: 10, selector: this.selector },
a); 0 >= d.number && (d.number = 1); e(this.selector).css("position", "relative"); b.push({ o: this.selector, position: e(this.selector).css("left") }); f.reset(this.selector)
    }, reset: function (a) { for (var c = 0; c < b.length; c++) if (b[c].o == a) { b[c].direction = "-="; b[c].animating = !1; b[c].execute = !1; b[c].interval = 0; break } }, start: function () { f.reset(this.selector); for (var a = 0; a < b.length; a++) if (b[a].o == this.selector) { b[a].execute = !0; break } }, stop: function () {
        f.reset(this.selector); for (var a = 0; a < b.length; a++) if (b[a].o == this.selector) {
            e(this.selector).animate({ marginLeft: b[a].position +
"px"
            }, d.speed, d.easing); break
        }
    }
    }; setInterval(function () { e.grep(b, function (a) { a.execute && g(a.o) }) }, 50); e.fn.alertShake = function (a) { if (f[a]) return f[a].apply(this, Array.prototype.slice.call(arguments, 1)); if ("object" === typeof a || !a) return f.init.apply(this, arguments); e.error("Method " + a + " does not exist on jQuery.alertShake."); return !1 }
})(jQuery, window, document);


/*-------------------------------------------------
Method: Setup AlertShake
-------------------------------------------------*/
$(document).ready(function () {
    $('#FirstName').alertShake();
    $('#LastName').alertShake();
    $('#EmailAddress').alertShake();
    $('#CompanyName').alertShake();
    validateForm();
});

/*-------------------------------------------------
Method: Validate MemberForm
-------------------------------------------------*/
function validateForm() {
    var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;

    $('#btnValidate').click(function () {
        var hasError = false;

        var firstNameVal = $('#FirstName')[0].value;
        if (firstNameVal == '') {
            $('#FirstName').alertShake('start');
            hasError = true;
        }

        var lastNameVal = $('#LastName')[0].value;
        if (lastNameVal == '') {
            $('#LastName').alertShake('start');
            hasError = true;
        }

        var emailAddressVal = $('#EmailAddress')[0].value;
        if (emailAddressVal == '') {
            $('#EmailAddress').alertShake('start');
            hasError = true;
        }
        else {
            if (!emailReg.test(emailAddressVal)) {
                $('#EmailAddress').alertShake('start');
                hasError = true;
            }
        }

        var companyNameVal = $('#CompanyName')[0].value;
        if (companyNameVal == '') {
            $('#CompanyName').alertShake('start');
            hasError = true;
        }

        if (hasError) {
            return false; // exist
        }
        else {
            createMember();
            $('#btnSubmit').click(); // Close modal window
        }
    });
}

/*-------------------------------------------------
Method: createMember
-------------------------------------------------*/
function createMember() {

    $.ajax({
        url: 'Classes/MemberManagerClass.aspx',
        data: { action: "insert",
            FirstName: $("#FirstName")[0].value,
            LastName: $("#LastName")[0].value,
            EmailAddress: $("#EmailAddress")[0].value,
            CompanyName: $("#CompanyName")[0].value,
            CurrentSystem: $("#CurrentSystem")[0].value
        },
        success: function (data) {
            l_memId = data.result;
            //alert('mem id:' + l_memId);
            $('#btnThankYou').click();
        },
        dataType: 'json',
        error: function (xhr, text, err) {
            alert(text);
        }
    });

}

