using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHub_Tester
{

    public class User_1:EntityBase
    {
        public string Title;
        public string Login;
        public User_1(long Id, string Title, string Login) 
        { 
            this.Id = Id;
            this.Title = Title;
            this.Login = Login;
        }
    }
}
