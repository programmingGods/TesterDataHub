using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHub_Tester
{
    public class Info_v1:EntityBaseInfo
    {
        public Info_v1(long Id, string Type, string Value) 
        {
            this.Id = Id;
            this.Type = Type;
            this.Value = Value;
        }

    }
}
