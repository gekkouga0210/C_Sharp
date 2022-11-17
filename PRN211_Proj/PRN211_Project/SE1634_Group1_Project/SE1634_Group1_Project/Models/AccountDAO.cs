using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1634_Group1_Project.Models
{
    internal class AccountDAO
    {
        public Account GetUser(string username, string password)
        {
            HappyQuizzContext context = new HappyQuizzContext();
            Account user = context.Accounts.Where(b => b.UserName == username && b.Password == password).FirstOrDefault();
            return user;
        }
    }
}
