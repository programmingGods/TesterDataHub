using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class Purchase
    {
        public long Id;
        public int IdUser;
        public int IdProduct;
        public Purchase(long Id, int IdUser, int IdProduct) 
        {
            this.Id = Id;
            this.IdUser = IdUser;
            this.IdProduct = IdProduct;
        }
    }
}
