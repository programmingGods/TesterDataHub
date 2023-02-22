using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class User : EntityBase
    {
        public User(long Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        //public string GenerateName(int length, string symbolsKit)
        //{
        //    string resultName = String.Empty;
        //    //char GeneratedSymbol = '\0';
        //    Random random = new Random();

        //    //length = textBoxUser;

        //    for (int i = 0; i < length; i++)
        //    {
        //        int generatedIndex = random.Next(0, symbolsKit.Length);

        //        //resultString[i] = symbolsKit[random.Next(symbolsKit.Length)];
        //        resultName = generatedIndex.ToString();
    //}
    //        return resultName;
    //    }
    }
}
