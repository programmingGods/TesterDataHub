//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace DataGridView
//{
//    public partial class Form1 : Form
//    {
//        public int startingPoint = 1;
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        public string Generatestr(int length, string symbolsKit)
//        {
//            string resultString = String.Empty;
//            char GeneratedSymbol = '\0';
//            Random random = new Random(startingPoint);

//            for (int i = 0; i < length; i++)
//            {
//                int generatedIndex = random.Next(0, symbolsKit.Length);

//                GeneratedSymbol = symbolsKit[generatedIndex];
//                resultString += GeneratedSymbol;
//                }

//            startingPoint += 100;
//            return resultString;

//        }
//        public User GenerateUser() 
//        {
//            Random random = new Random();
//            long generatedId = random.Next(1, 100);
//            int numberLength = 10;
//            string symbolsKit = "0123456789";
//            string genereatedPhone = "+7" + Generatestr(numberLength, symbolsKit);

//            User user = new User(generatedId, genereatedPhone);
//            return user;

//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            dataGridView1.Columns.Add("ID", "id");
//            dataGridView1.Columns.Add("Name", "Name");

//            dataGridView1.Rows[0].Cells["ID"].Value = 1;
//            dataGridView1.Rows[0].Cells[1].Value = 2;
//            for (int i = 1; i < 1; i++)
//            {
//                this.dataGridView1.Rows.Add();
//            }

//            dataGridView2.Columns.Add("ID", "id");
//            dataGridView2.Columns.Add("Name", "name");

//            dataGridView2.Rows[0].Cells["ID"].Value = 1;
//            dataGridView2.Rows[0].Cells[1].Value = 2;
//            for (int i = 1; i < 1; i++)
//            {
//                this.dataGridView2.Rows.Add();

//            }

//            dataGridView3.Columns.Add("ID", "id");
//            dataGridView3.Columns.Add("IdUser", "IdUser");
//            dataGridView3.Columns.Add("IdProduct", "idproduct");

//            dataGridView3.Rows[0].Cells["ID"].Value = 1;
//            dataGridView3.Rows[0].Cells[1].Value = 2;
//            dataGridView3.Rows[0].Cells[2].Value = 3;
//            for (int i = 1; i < 1; i++)
//            {
//                this.dataGridView3.Rows.Add();
//            }

//            dataGridView4.Columns.Add("ID", "id");
//            dataGridView4.Columns.Add("IdUser", "iduser");
//            dataGridView4.Columns.Add("Name", "name");

//            dataGridView4.Rows[0].Cells["ID"].Value = 1;
//            dataGridView4.Rows[0].Cells[1].Value = 2;
//            dataGridView4.Rows[0].Cells[2].Value = 3;
//            for (int i = 1; i < 1; i++)
//            {
//                this.dataGridView4.Rows.Add();
//            }

//            dataGridView5.Columns.Add("ID", "id");
//            dataGridView5.Columns.Add("IdUser", "iduser");
//            dataGridView5.Columns.Add("Number", "number");

//            dataGridView5.Rows[0].Cells["ID"].Value = 1;
//            dataGridView5.Rows[0].Cells[1].Value = 2;
//            dataGridView5.Rows[0].Cells[2].Value = 3;
//            for (int i = 1; i < 1; i++)
//            {
//                this.dataGridView5.Rows.Add();
//            }


//        }

//        private void generateUser_Click(object sender, EventArgs e)
//        {
//            //for (int i = 0; i < 1; i++)
//            //{
//            //    int rowNumber = dataGridView1.Rows.Add();
//            //    dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
//            //    dataGridView1.Rows[rowNumber].Cells[1].Value = textBoxUser;
//            //}

//            //List<User> Users = new List<User>();

//            //for (int i = 0; i < 100; i++)
//            //{
//            //    Users.Add(GenerateUser());
//            //}

//            //Тестируем GenerateStr
//            List<string> testGeneratStr = new List<string>();

//            for (int i = 0; i < 100; i++)
//            {
//                testGeneratStr.Add(Generatestr(5, "абвгдеёжзий"));
//            }
//        }

//        private void GenerateProduct_Click(object sender, EventArgs e)
//        {

//            //for (int i = 0; i < 1; i++)
//            //{
//            //    int rowNumber = dataGridView2.Rows.Add();
//            //    dataGridView2.Rows[rowNumber].Cells["ID"].Value = rowNumber;
//            //    dataGridView2.Rows[rowNumber].Cells[1].Value = textBoxProduct;
//            //}

//        }

//        private void GeneratePurchase_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 1; i++)
//            {
//                int rowNumber = dataGridView3.Rows.Add();
//                dataGridView3.Rows[rowNumber].Cells["ID"].Value = rowNumber;
//                dataGridView3.Rows[rowNumber].Cells[1].Value = rowNumber;
//                dataGridView3.Rows[rowNumber].Cells[2].Value = textBoxPurchase;
//            }

//        }

//        private void GenerateSocialNetwork_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 1; i++)
//            {
//                int rowNumber = dataGridView4.Rows.Add();
//                dataGridView4.Rows[rowNumber].Cells["ID"].Value = rowNumber;
//                dataGridView4.Rows[rowNumber].Cells[1].Value = rowNumber;
//                dataGridView4.Rows[rowNumber].Cells[2].Value = textBoxSocialNetwork;
//            }

//        }

//        private void GeneratePhoneNumber_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 1; i++)
//            {
//                int rowNumber = dataGridView5.Rows.Add();
//                dataGridView5.Rows[rowNumber].Cells["ID"].Value = rowNumber;
//                dataGridView5.Rows[rowNumber].Cells[1].Value = rowNumber;
//                dataGridView5.Rows[rowNumber].Cells[2].Value = textBoxPhoneNumber;
//            }

//        }


//        /*private void textBox1_TextChanged_1(object sender, EventArgs e)
//        {
//            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
//         String.Format("[ID] like '{0}%'", textBox1.Text);
//            label1.Text = dataGridView1.RowCount.ToString();

//        }*/
//    }
//}
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public int startingPoint = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public string Generatestr(int length, string symbolsKit)
        {
            string resultString = String.Empty;
            char GeneratedSymbol = '\0';
            Random random = new Random(startingPoint);

            for (int i = 0; i < length; i++)
            {
                int generatedIndex = random.Next(0, symbolsKit.Length);

                GeneratedSymbol = symbolsKit[generatedIndex];
                resultString += GeneratedSymbol;
            }

            startingPoint += 100;
            return resultString;

        }
        public User GenerateUser()
        {
            Random random = new Random(startingPoint);
            long generatedId = random.Next(1, 100);
            int numberLength = 10;
            string symbolsKit = "0123456789";
            string genereatedPhone = "+7" + Generatestr(numberLength, symbolsKit);

            User user = new User(generatedId, genereatedPhone);
            startingPoint += 100;
            return user;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "id");
            dataGridView1.Columns.Add("Name", "Name");

            dataGridView1.Rows[0].Cells["ID"].Value = 1;
            dataGridView1.Rows[0].Cells[1].Value = 2;
            for (int i = 1; i < 1; i++)
            {
                this.dataGridView1.Rows.Add();
            }

            dataGridView2.Columns.Add("ID", "id");
            dataGridView2.Columns.Add("Name", "name");

            dataGridView2.Rows[0].Cells["ID"].Value = 1;
            dataGridView2.Rows[0].Cells[1].Value = 2;
            for (int i = 1; i < 1; i++)
            {
                this.dataGridView2.Rows.Add();

            }

            dataGridView3.Columns.Add("ID", "id");
            dataGridView3.Columns.Add("IdUser", "IdUser");
            dataGridView3.Columns.Add("IdProduct", "idproduct");

            dataGridView3.Rows[0].Cells["ID"].Value = 1;
            dataGridView3.Rows[0].Cells[1].Value = 2;
            dataGridView3.Rows[0].Cells[2].Value = 3;
            for (int i = 1; i < 1; i++)
            {
                this.dataGridView3.Rows.Add();
            }

            dataGridView4.Columns.Add("ID", "id");
            dataGridView4.Columns.Add("IdUser", "iduser");
            dataGridView4.Columns.Add("Name", "name");

            dataGridView4.Rows[0].Cells["ID"].Value = 1;
            dataGridView4.Rows[0].Cells[1].Value = 2;
            dataGridView4.Rows[0].Cells[2].Value = 3;
            for (int i = 1; i < 1; i++)
            {
                this.dataGridView4.Rows.Add();
            }

            dataGridView5.Columns.Add("ID", "id");
            dataGridView5.Columns.Add("IdUser", "iduser");
            dataGridView5.Columns.Add("Number", "number");

            dataGridView5.Rows[0].Cells["ID"].Value = 1;
            dataGridView5.Rows[0].Cells[1].Value = 2;
            dataGridView5.Rows[0].Cells[2].Value = 3;
            for (int i = 1; i < 1; i++)
            {
                this.dataGridView5.Rows.Add();
            }


        }

        private void generateUser_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 1; i++)
            //{
            //    int rowNumber = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            //    dataGridView1.Rows[rowNumber].Cells[1].Value = textBoxUser;
            //}
        }

private void GenerateProduct_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < 1; i++)
            //{
            //    int rowNumber = dataGridView2.Rows.Add();
            //    dataGridView2.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            //    dataGridView2.Rows[rowNumber].Cells[1].Value = textBoxProduct;
            //}

        }

        private void GeneratePurchase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                int rowNumber = dataGridView3.Rows.Add();
                dataGridView3.Rows[rowNumber].Cells["ID"].Value = rowNumber;
                dataGridView3.Rows[rowNumber].Cells[1].Value = rowNumber;
                dataGridView3.Rows[rowNumber].Cells[2].Value = textBoxPurchase;
            }

        }

        private void GenerateSocialNetwork_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                int rowNumber = dataGridView4.Rows.Add();
                dataGridView4.Rows[rowNumber].Cells["ID"].Value = rowNumber;
                dataGridView4.Rows[rowNumber].Cells[1].Value = rowNumber;
                dataGridView4.Rows[rowNumber].Cells[2].Value = textBoxSocialNetwork;
            }

        }

        private void GeneratePhoneNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                int rowNumber = dataGridView5.Rows.Add();
                dataGridView5.Rows[rowNumber].Cells["ID"].Value = rowNumber;
                dataGridView5.Rows[rowNumber].Cells[1].Value = rowNumber;
                dataGridView5.Rows[rowNumber].Cells[2].Value = textBoxPhoneNumber;
            }

        }


        /*private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
         String.Format("[ID] like '{0}%'", textBox1.Text);
            label1.Text = dataGridView1.RowCount.ToString();

        }*/
    }
}

