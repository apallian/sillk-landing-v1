using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;

namespace BLL
{
    public class MemberManager: BaseHandler
    {
        public Int32 InsertMember(string firstName, string lastName, string companyName, string email, string password, string paymentToken, string customerToken, string currentSystem)
        {
            int memberId = 0;

            if (!IsMemberExisted(firstName, lastName, companyName, email, currentSystem))
            {
                Member mem = new Member();
                mem.FirstName = firstName;
                mem.LastName = lastName;
                mem.CompanyName = companyName;
                mem.Email = email;
                mem.Password = password;
                mem.PaymentToken = paymentToken;
                mem.CustomerToken = customerToken;
                mem.CurrentSystem = currentSystem;

                try
                {
                    Add(mem);
                    memberId = mem.Id;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return memberId;
        }

        public bool IsMemberExisted(string firstName, string lastName, string companyName, string emailAddress, string currentSystem)
        {
            IQueryable<Member> mem = Repository.Uow.Members.Where(m => m.FirstName == firstName && m.LastName == lastName && m.CompanyName == companyName && m.Email == emailAddress && m.CurrentSystem == currentSystem);
            if (mem.Count() == 0)
            {
                return false;
            }

            return true;
        }
    }
}
