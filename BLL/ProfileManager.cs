using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using Jayrock;
using Jayrock.Json;

namespace BLL
{
    public class ProfileManager : BaseHandler
    {
        #region ::: InsertProfile
        public Int32 InsertProfile(string destination, string name, string email)
        {
            int profileId = 0;
            Profile profile = new Profile();
            profile.Name = name;
            profile.Email = email;
            profile.Destination = destination;

            try
            {
                Add(profile);
                profileId = profile.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return profileId;
        }
        #endregion

        #region ::: InsertProfileLocationInfo
        public Int32 InsertProfileLocationInfo(string ip, string countryCode, string countryName, string regionName, string city, string latitude, string longitude, string continentName, Int32 profileId)
        {
            int profileLocationId = 0;
            ProfileLocationInfo pLocInfo = new ProfileLocationInfo();
            pLocInfo.Ip = ip;
            pLocInfo.CountryCode = countryCode;
            pLocInfo.CountryName = countryName;
            pLocInfo.RegionName = regionName;
            pLocInfo.City = city;
            pLocInfo.Latitude = latitude;
            pLocInfo.Longitude = longitude;
            pLocInfo.ContinentName = continentName;
            pLocInfo.LastVisitedTime = DateTime.Now;
            pLocInfo.ProfileId = profileId;

            try
            {
                Add(pLocInfo);
                profileLocationId = pLocInfo.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return profileLocationId;
        }
        #endregion
    }
}
