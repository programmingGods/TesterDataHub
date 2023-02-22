using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class PhoneNumber
    {
        long Id;
        int IdUser;
        string Number;

        public PhoneNumber(long Id, int IdUser, string Number) 
        {
            this.Id = Id;
            this.IdUser = IdUser;
            this.Number = Number;
        }
    }
}
