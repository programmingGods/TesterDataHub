using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataHub_Tester
{
    
    public partial class Form1 : Form
    {
        public long generatedId = 1;
        public int startingPoint = 1;

        public Form1()
        {
            InitializeComponent();
        }
        void comboBoxEntityes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
                switch(comboBoxEntityes.SelectedIndex)
            {
                case 0:
                    dataGridView1.Columns.Add("Id", "id");
                    dataGridView1.Columns.Add("Type", "type");
                    dataGridView1.Columns.Add("Value", "value");
                    break;

                case 1:
                    dataGridView1.Columns.Add("Id", "id");
                    dataGridView1.Columns.Add("Title", "title");
                    dataGridView1.Columns.Add("Login", "login");
                    break;

                case 2:
                    dataGridView1.Columns.Add("Id", "id");
                    dataGridView1.Columns.Add("UserId", "userid");
                    dataGridView1.Columns.Add("InfoId", "infoId");
                    break;

                case 3:
                    dataGridView1.Columns.Add("Id", "id");
                    dataGridView1.Columns.Add("UserId", "userid");
                    dataGridView1.Columns.Add("Type", "type");
                    dataGridView1.Columns.Add("Value", "value");
                    break;
            }       
        }

        public string GenerateStr(int length, string symbolsKit)
        {
            string resultString = string.Empty;
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

        public Info_v1 GenerateInfo_v1()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            List<string> listType = (new string[] { "mail", "number", "link"}.ToList());
            string generatedType = listType[new Random(startingPoint).Next(listType.Count)];
            //string generatedType = GenerateStr(numberLength, symbolsKit);
            //string generatedValue =  GenerateStr(numberLength, symbolsKit);
            string generatedValue = "";
            if (generatedType == "mail")
            {
                generatedValue = GenerateStr(numberLength, symbolsKit) + "@gmail.com";
            }
            else if (generatedType == "number")
            {
                generatedValue = "+7" + GenerateStr(numberLength, symbolsKit);
            }
            else if (generatedType == "link")
            {
                generatedValue = "https://vk.com/" + GenerateStr(numberLength, symbolsKit);
            }

            Info_v1 info_v1 = new Info_v1(generatedId, generatedType, generatedValue);
            startingPoint += 100;
            generatedId++;
            return info_v1;
        }

        public User_1 GenerateUser_1()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string generatedTitle = GenerateStr(numberLength, symbolsKit);
            string generatedLogin =  GenerateStr(numberLength, symbolsKit);

            User_1 user_1 = new User_1(generatedId, generatedTitle, generatedLogin);
            startingPoint += 100;
            generatedId++;
            return user_1;
        }

        public UserInfo_v1 GenerateUserInfo_v1()
        {
            Random random = new Random(startingPoint);

            int generatedUserId = random.Next(1, 100);
            int generatedInfoId = random.Next(1, 100);

            UserInfo_v1 userInfo_v1 = new UserInfo_v1(generatedId, generatedUserId, generatedInfoId);
            startingPoint += 100;
            generatedId++;
            return userInfo_v1;

        }

        public UserInfo_v2 GenerateUserInfo_v2()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int generatedUserId = random.Next(1, 100);
            List<string> listType = (new string[] { "mail", "number", "link" }.ToList());
            string generatedType = listType[new Random(startingPoint).Next(listType.Count)];
            //string generatedType = GenerateStr(numberLength, symbolsKit);
            string generatedValue = "";
            if (generatedType == "mail")
            {
                generatedValue = GenerateStr(numberLength, symbolsKit) + "@gmail.com";
            }
            else if (generatedType == "number")
            {
                generatedValue = "+7" + GenerateStr(numberLength, symbolsKit);
            }
            else if (generatedType == "link")
            {
                generatedValue = "https://vk.com/" + GenerateStr(numberLength, symbolsKit);
            }

            //string generatedValue = generatedValue;

            UserInfo_v2 userInfo_v2 = new UserInfo_v2(generatedId, generatedUserId, generatedType, generatedValue);
            startingPoint += 100;
            generatedId++;
            return userInfo_v2;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (comboBoxEntityes.SelectedIndex == 0)
            {
                List<Info_v1> info_v1 = new List<Info_v1>();
                int quantityInfo_v1 = Int32.Parse(quantityInstanceTextBox.Text);
                for (int i = 0; i < quantityInfo_v1; i++)
                {
                    info_v1.Add(GenerateInfo_v1());
                }
                for (int i = 0;i < quantityInfo_v1; i++)
                {
                    dataGridView1.Rows.Add(info_v1[i].Id, info_v1[i].Type, info_v1[i].Value);
                }
            }

            else if (comboBoxEntityes.SelectedIndex == 1) 
            {
                List<User_1> user_1 = new List<User_1>();
                int quantityUser_1 = Int32.Parse(quantityInstanceTextBox.Text); 
                for (int i = 0; i < quantityUser_1; i++)
                {
                    user_1.Add(GenerateUser_1());
                }
                for (int i = 0;i < quantityUser_1; i++)
                {
                    dataGridView1.Rows.Add(user_1[i].Id, user_1[i].Title, user_1[i].Login);
                }
            }

            else if (comboBoxEntityes.SelectedIndex == 2)
            {
                List<UserInfo_v1> userInfo_v1 = new List<UserInfo_v1>();
                int quantityUserInfo_v1 = Int32.Parse(quantityInstanceTextBox.Text);
                for (int i = 0; i < quantityUserInfo_v1; i++)
                {
                    userInfo_v1.Add(GenerateUserInfo_v1());
                }
                for (int i = 0; i < quantityUserInfo_v1; i++)
                {
                    dataGridView1.Rows.Add(userInfo_v1[i].Id, userInfo_v1[i].UserId, userInfo_v1[i].InfoId);
                }
            }

            else if (comboBoxEntityes.SelectedIndex == 3)
            {
                List<UserInfo_v2> userInfo_v2 = new List<UserInfo_v2>();
                int quantityUserInfo_v2 = Int32.Parse(quantityInstanceTextBox.Text);
                for (int i = 0; i < quantityUserInfo_v2; i++)
                {
                    userInfo_v2.Add(GenerateUserInfo_v2());
                }
                for (int i = 0; i < quantityUserInfo_v2; i++)
                {
                    dataGridView1.Rows.Add(userInfo_v2[i].Id, userInfo_v2[i].UserId, userInfo_v2[i].Type, userInfo_v2[i].Value);
                }
            }
        }
    }
}
