using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using Jayrock;
using Jayrock.Json;

namespace BLL
{
    public class BusinessManager : BaseHandler
    {
        public Int32 InsertBusiness(string name, string businessName, string city)
        {
            int businessId = 0;
            Business bus = new Business();
            bus.Name = name;
            bus.BusinessName = businessName;
            bus.City = city;

            try
            {
                Add(bus);
                businessId = bus.Id;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                throw ex; ;
            }

            return businessId;
        }
    }
}
