using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace DAL
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class Profile : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 1024)]
    private string _name;
    [ValidatePresence]
    [ValidateEmailAddress]
    [ValidateLength(0, 2048)]
    private string _email;
    [ValidateLength(0, 1024)]
    private string _destination;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the Email entity attribute.</summary>
    public const string EmailField = "Email";
    /// <summary>Identifies the Destination entity attribute.</summary>
    public const string DestinationField = "Destination";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Profile")]
    private readonly EntityCollection<ProfileLocationInfo> _profileLocationInfos = new EntityCollection<ProfileLocationInfo>();


    #endregion
    
    #region Properties

    public EntityCollection<ProfileLocationInfo> ProfileLocationInfos
    {
      get { return Get(_profileLocationInfos); }
    }


    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    public string Email
    {
      get { return Get(ref _email, "Email"); }
      set { Set(ref _email, value, "Email"); }
    }

    public string Destination
    {
      get { return Get(ref _destination, "Destination"); }
      set { Set(ref _destination, value, "Destination"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class ProfileLocationInfo : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 32)]
    private string _ip;
    [ValidatePresence]
    [ValidateLength(0, 512)]
    private string _countryCode;
    [ValidatePresence]
    private string _countryName;
    [ValidatePresence]
    private string _regionName;
    [ValidatePresence]
    private string _city;
    [ValidatePresence]
    private string _latitude;
    [ValidatePresence]
    private string _longitude;
    private System.DateTime _lastVisitedTime;
    [ValidatePresence]
    [ValidateLength(0, 512)]
    private string _continentName;
    private int _profileId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Ip entity attribute.</summary>
    public const string IpField = "Ip";
    /// <summary>Identifies the CountryCode entity attribute.</summary>
    public const string CountryCodeField = "CountryCode";
    /// <summary>Identifies the CountryName entity attribute.</summary>
    public const string CountryNameField = "CountryName";
    /// <summary>Identifies the RegionName entity attribute.</summary>
    public const string RegionNameField = "RegionName";
    /// <summary>Identifies the City entity attribute.</summary>
    public const string CityField = "City";
    /// <summary>Identifies the Latitude entity attribute.</summary>
    public const string LatitudeField = "Latitude";
    /// <summary>Identifies the Longitude entity attribute.</summary>
    public const string LongitudeField = "Longitude";
    /// <summary>Identifies the LastVisitedTime entity attribute.</summary>
    public const string LastVisitedTimeField = "LastVisitedTime";
    /// <summary>Identifies the ContinentName entity attribute.</summary>
    public const string ContinentNameField = "ContinentName";
    /// <summary>Identifies the ProfileId entity attribute.</summary>
    public const string ProfileIdField = "ProfileId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ProfileLocationInfos")]
    private readonly EntityHolder<Profile> _profile = new EntityHolder<Profile>();


    #endregion
    
    #region Properties

    public Profile Profile
    {
      get { return Get(_profile); }
      set { Set(_profile, value); }
    }


    public string Ip
    {
      get { return Get(ref _ip, "Ip"); }
      set { Set(ref _ip, value, "Ip"); }
    }

    public string CountryCode
    {
      get { return Get(ref _countryCode, "CountryCode"); }
      set { Set(ref _countryCode, value, "CountryCode"); }
    }

    public string CountryName
    {
      get { return Get(ref _countryName, "CountryName"); }
      set { Set(ref _countryName, value, "CountryName"); }
    }

    public string RegionName
    {
      get { return Get(ref _regionName, "RegionName"); }
      set { Set(ref _regionName, value, "RegionName"); }
    }

    public string City
    {
      get { return Get(ref _city, "City"); }
      set { Set(ref _city, value, "City"); }
    }

    public string Latitude
    {
      get { return Get(ref _latitude, "Latitude"); }
      set { Set(ref _latitude, value, "Latitude"); }
    }

    public string Longitude
    {
      get { return Get(ref _longitude, "Longitude"); }
      set { Set(ref _longitude, value, "Longitude"); }
    }

    public System.DateTime LastVisitedTime
    {
      get { return Get(ref _lastVisitedTime, "LastVisitedTime"); }
      set { Set(ref _lastVisitedTime, value, "LastVisitedTime"); }
    }

    public string ContinentName
    {
      get { return Get(ref _continentName, "ContinentName"); }
      set { Set(ref _continentName, value, "ContinentName"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Profile" /> property.</summary>
    public int ProfileId
    {
      get { return Get(ref _profileId, "ProfileId"); }
      set { Set(ref _profileId, value, "ProfileId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class Business : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 2048)]
    private string _businessName;
    [ValidatePresence]
    [ValidateLength(0, 1024)]
    private string _name;
    [ValidateLength(0, 1024)]
    private string _city;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the BusinessName entity attribute.</summary>
    public const string BusinessNameField = "BusinessName";
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the City entity attribute.</summary>
    public const string CityField = "City";


    #endregion
    
    #region Properties



    public string BusinessName
    {
      get { return Get(ref _businessName, "BusinessName"); }
      set { Set(ref _businessName, value, "BusinessName"); }
    }

    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    public string City
    {
      get { return Get(ref _city, "City"); }
      set { Set(ref _city, value, "City"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdentityMethod=IdentityMethod.IdentityColumn)]
  public partial class Member : Entity<int>
  {
    #region Fields
  
    private string _firstName;
    private string _lastName;
    private string _companyName;
    private string _email;
    private string _password;
    private string _paymentToken;
    private string _customerToken;
    private string _currentSystem;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the FirstName entity attribute.</summary>
    public const string FirstNameField = "FirstName";
    /// <summary>Identifies the LastName entity attribute.</summary>
    public const string LastNameField = "LastName";
    /// <summary>Identifies the CompanyName entity attribute.</summary>
    public const string CompanyNameField = "CompanyName";
    /// <summary>Identifies the Email entity attribute.</summary>
    public const string EmailField = "Email";
    /// <summary>Identifies the Password entity attribute.</summary>
    public const string PasswordField = "Password";
    /// <summary>Identifies the PaymentToken entity attribute.</summary>
    public const string PaymentTokenField = "PaymentToken";
    /// <summary>Identifies the CustomerToken entity attribute.</summary>
    public const string CustomerTokenField = "CustomerToken";
    /// <summary>Identifies the CurrentSystem entity attribute.</summary>
    public const string CurrentSystemField = "CurrentSystem";


    #endregion
    
    #region Properties



    public string FirstName
    {
      get { return Get(ref _firstName, "FirstName"); }
      set { Set(ref _firstName, value, "FirstName"); }
    }

    public string LastName
    {
      get { return Get(ref _lastName, "LastName"); }
      set { Set(ref _lastName, value, "LastName"); }
    }

    public string CompanyName
    {
      get { return Get(ref _companyName, "CompanyName"); }
      set { Set(ref _companyName, value, "CompanyName"); }
    }

    public string Email
    {
      get { return Get(ref _email, "Email"); }
      set { Set(ref _email, value, "Email"); }
    }

    public string Password
    {
      get { return Get(ref _password, "Password"); }
      set { Set(ref _password, value, "Password"); }
    }

    public string PaymentToken
    {
      get { return Get(ref _paymentToken, "PaymentToken"); }
      set { Set(ref _paymentToken, value, "PaymentToken"); }
    }

    public string CustomerToken
    {
      get { return Get(ref _customerToken, "CustomerToken"); }
      set { Set(ref _customerToken, value, "CustomerToken"); }
    }

    public string CurrentSystem
    {
      get { return Get(ref _currentSystem, "CurrentSystem"); }
      set { Set(ref _currentSystem, value, "CurrentSystem"); }
    }

    #endregion
  }



  /// <summary>
  /// Provides a strong-typed unit of work for working with the SilkRoute model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class SilkRouteUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Profile> Profiles
    {
      get { return this.Query<Profile>(); }
    }
    
    public System.Linq.IQueryable<ProfileLocationInfo> ProfileLocationInfos
    {
      get { return this.Query<ProfileLocationInfo>(); }
    }
    
    public System.Linq.IQueryable<Business> Businesses
    {
      get { return this.Query<Business>(); }
    }
    
    public System.Linq.IQueryable<Member> Members
    {
      get { return this.Query<Member>(); }
    }
    
  }

}
