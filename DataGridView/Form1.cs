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
using System.Security.Cryptography.X509Certificates;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public long generatedId = 1;
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
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string genereatedName = Generatestr(numberLength, symbolsKit);

            User user = new User(generatedId, genereatedName);
            startingPoint += 100;
            generatedId++;
            return user;
        }

        public Product GenerateProduct()
        { 
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string generatedName = Generatestr(numberLength, symbolsKit);

            Product product = new Product(generatedId, generatedName);
            startingPoint += 100;
            generatedId++;
            return product;
        }
        public Purchase GeneratePurchase()
        {
            Random random = new Random(startingPoint);
            int generatedIdUser = random.Next(1, 100);
            int generatedIdProduct = random.Next(1, 100);

            Purchase purchase = new Purchase(generatedId, generatedIdUser, generatedIdProduct);
            startingPoint += 100;
            generatedId++;
            return purchase;
        }

        public SocialNetwork GenerateSocialNetwork()
        {
            Random random = new Random(startingPoint);
            int numberLength = 13;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int generatedIdUser = random.Next(1, 100);
            string generatedName = Generatestr(numberLength, symbolsKit);

            SocialNetwork socialNetwork = new SocialNetwork(generatedId, generatedName,generatedIdUser);
            startingPoint += 100;
            generatedId++;
            return socialNetwork;
        }

        public PhoneNumber GeneratePhoneNumber()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "0123456789";
            int generatedIdUser = random.Next(1, 100);
            string generatedNumber = "+7" + Generatestr(numberLength, symbolsKit);

            PhoneNumber phoneNumber = new PhoneNumber(generatedId, generatedIdUser, generatedNumber);
            startingPoint += 100;
            generatedId++;
            return phoneNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "id");
            dataGridView1.Columns.Add("Name", "Name");

            //dataGridView1.Rows[0].Cells["ID"].Value = 1;
            //dataGridView1.Rows[0].Cells[1].Value = 2;

            for (int i = 1; i < 1; i++)
            {
                this.dataGridView1.Rows.Add();
            }

            dataGridView2.Columns.Add("ID", "id");
            dataGridView2.Columns.Add("Name", "name");

            //dataGridView2.Rows[0].Cells["ID"].Value = 1;
            //dataGridView2.Rows[0].Cells[1].Value = 2;

            for (int i = 1; i < 1; i++)
            {
                this.dataGridView2.Rows.Add();
            }

            dataGridView3.Columns.Add("ID", "id");
            dataGridView3.Columns.Add("IdUser", "iduser");
            dataGridView3.Columns.Add("IdProduct", "idproduct");

            //dataGridView3.Rows[0].Cells["ID"].Value = 1;
            //dataGridView3.Rows[0].Cells[1].Value = 2;
            //dataGridView3.Rows[0].Cells[2].Value = 3;

            for (int i = 1; i < 1; i++)
            {
                this.dataGridView3.Rows.Add();
            }

            dataGridView4.Columns.Add("ID", "id");
            dataGridView4.Columns.Add("IdUser", "iduser");
            dataGridView4.Columns.Add("Name", "name");

            //dataGridView4.Rows[0].Cells["ID"].Value = 1;
            //dataGridView4.Rows[0].Cells[1].Value = 2;
            //dataGridView4.Rows[0].Cells[2].Value = 3;

            for (int i = 1; i < 1; i++)
            {
                this.dataGridView4.Rows.Add();
            }

            dataGridView5.Columns.Add("ID", "id");
            dataGridView5.Columns.Add("IdUser", "iduser");
            dataGridView5.Columns.Add("Number", "number");

            //dataGridView5.Rows[0].Cells["ID"].Value = 1;
            //dataGridView5.Rows[0].Cells[1].Value = 2;
            //dataGridView5.Rows[0].Cells[2].Value = 3;

            for (int i = 1; i < 1; i++)
            {
                this.dataGridView5.Rows.Add();
            }
        }

        private void generateUser_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            int quantityUsers = Int32.Parse(textBoxUser.Text);
            for (int i = 0; i < quantityUsers; i++)
            {
                users.Add(GenerateUser());
            }

            for (int i = 0; i < users.Count; i++)
            {
                dataGridView1.Rows.Add(users[i].Id, users[i].Name);
            }
            //List<User> Users = new List<User>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Users.Add(GenerateUser());
            //}

            ////Тестируем GenerateStr
            //List<string> testGeneratStr = new List<string>();

            //for (int i = 0; i < 100; i++)
            //{
            //    testGeneratStr.Add(Generatestr(5, "абвгдеёжзий"));
            //}
            ////dataGridView1.Rows.Add(generateUser);
            //dataGridView1.Rows[2].Cells[0].Value = "new value";
        }

        private void GenerateProduct_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            int quantitydProducts = Int32.Parse(textBoxProduct.Text);
            for (int i = 0; i < quantitydProducts; i++)
            {
                products.Add(GenerateProduct());
            }
            for(int i = 0;i < products.Count;i++) 
            {
                dataGridView2.Rows.Add(products[i].Id, products[i].Name);
            }
           
            //List<Product> Product = new List<Product>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Product.Add(GenerateProduct());
            //}

            ////Тестируем GenerateStr
            //List<string> testGeneratStr = new List<string>();

            //for (int i = 0; i < 100; i++)
            //{
            //    testGeneratStr.Add(Generatestr(5, "абвгдеёжзий"));
            //}
        }

        private void GeneratePurchase_Click(object sender, EventArgs e)
        {
            List<Purchase> purchases = new List<Purchase>(); 
            int quantityPurchases = Int32.Parse(textBoxPurchase.Text);
            for (int i = 0; i < quantityPurchases; i++)
            {
                purchases.Add(GeneratePurchase());
            }
            for (int i = 0; i < purchases.Count; i++)
            {
                dataGridView3.Rows.Add(purchases[i].Id, purchases[i].IdUser, purchases[i].IdProduct);
            }
            //List<Purchase> purchases = new List<Purchase>();
            //for (int i = 0; i < 100; i++)
            //{
            //    purchases.Add(GeneratePurchase());
            //}
        }

        private void GenerateSocialNetwork_Click(object sender, EventArgs e)
        {
            List<SocialNetwork> socialNetworks = new List<SocialNetwork>();
            int quantitySocialNetworks = Int32.Parse(textBoxSocialNetwork.Text);
            for (int i = 0; i < quantitySocialNetworks; i++)
            {
                socialNetworks.Add(GenerateSocialNetwork());
            }
            for (int i = 0; i < socialNetworks.Count; i++)
            {
                dataGridView4.Rows.Add(socialNetworks[i].Id, socialNetworks[i].IdUser, socialNetworks[i].Name);
            }
            //List<SocialNetwork> socialNetworks = new List<SocialNetwork>();
            //for (int i = 0; i < 100; i++)
            //{
            //    socialNetworks.Add(GenerateSocialNetwork());
            //}

            ////Тестируем GenerateStr
            //List<string> testGeneratStr = new List<string>();

            //for (int i = 0; i < 100; i++)
            //{
            //    testGeneratStr.Add(Generatestr(5, "абвгдеёжзий"));
            //}
        }

        private void GeneratePhoneNumber_Click(object sender, EventArgs e)
        {
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
            int PhoneNumbers = Int32.Parse(textBoxPhoneNumber.Text);
            for (int i = 0; i < PhoneNumbers; i++)
            {
                phoneNumbers.Add(GeneratePhoneNumber());
            }
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                dataGridView5.Rows.Add(phoneNumbers[i].Id, phoneNumbers[i].IdUser, phoneNumbers[i].Number);
            }
            //List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
            //for (int i = 0; i < 100; i++)
            //{
            //    phoneNumbers.Add(GeneratePhoneNumber());
            //}
        }
    }
}



