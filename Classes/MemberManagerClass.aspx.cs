using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Jayrock.Json;
using BLL;

namespace SilkRoute.GoSillk.Classes
{
	public partial class MemberManagerClass : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            JsonObject jObj = new JsonObject();

            switch (Request["action"].ToString())
            {
                // insert action
                case "insert":

                    MemberManager memMgr = new MemberManager();
                    string firstName = Request["FirstName"].ToString();
                    string lastName = Request["LastName"].ToString();
                    string emailAddress = Request["EmailAddress"].ToString();
                    string companyName = Request["CompanyName"].ToString();
                    string currentSystem = Request["CurrentSystem"].ToString();

                    int mid = memMgr.InsertMember(firstName, lastName, companyName, emailAddress, "", "", "", currentSystem);
                    
                    if (mid > 0)
                    {
                        jObj["result"] = mid;
                    }
                    else
                    {
                        jObj["result"] = 0;
                    }

                    Response.Write(jObj);
                    break;
            }
		}
	}
}