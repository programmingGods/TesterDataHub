using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class SocialNetwork : EntityBase
    {
        int IdUser;
        public SocialNetwork(long Id, string Name, int IdUser)
        {
            this.Id = Id;
            this.Name = Name;
            this.IdUser = IdUser;

        }

    }
}
