using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHub_Tester
{
    public class UserInfo_v2:EntityBaseInfo
    {
        public long UserId;
        public UserInfo_v2(long Id, long UserId, string Type, string Value) 
        { 
            this.Id = Id;
            this.UserId = UserId;
            this.Type = Type;
            this.Value = Value;
        }
    }
}
