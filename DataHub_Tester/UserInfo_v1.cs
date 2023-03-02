using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHub_Tester
{
    public class UserInfo_v1:EntityBase
    {
        public long UserId;
        public long InfoId;
        public UserInfo_v1(long Id, long UserId, long InfoId) 
        { 
            this.Id = Id;
            this.UserId = UserId;
            this.InfoId = InfoId;
        }
    }
}
