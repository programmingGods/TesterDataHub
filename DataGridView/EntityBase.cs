using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class EntityBase:EntityEmpty
    {
        public string Name { get; set; }
        public long Id { get; set; }

        //public EntityBase(int Id, string Name) 
        //{
        //    this.Name = Name;
        //    this.Id = Id;
        //}

    }
}
