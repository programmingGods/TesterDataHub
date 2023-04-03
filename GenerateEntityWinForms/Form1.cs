using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GenerateEntityWinForms
{
    public partial class Form1 : Form
    {
        //Списки для добавления данных
        List<InfoV1> generatedInfoV1 = new List<InfoV1>();
        List<User1> generatedUsers = new List<User1>();        
        List<UserInfoV1> generatedUserInfoV1 = new List<UserInfoV1>();
        List<UserInfoV2> generatedUserInfoV2 = new List<UserInfoV2>();

        //Списки для обновления данных
        List<InfoV1> updateInfoV1 = new List<InfoV1>();
        List<User1> updateUsers = new List<User1>();
        List<UserInfoV1> updateUserInfoV1 = new List<UserInfoV1>();
        List<UserInfoV2> updateUserInfoV2 = new List<UserInfoV2>();


        //Списки для удаления данных
        List<User1> deleteUsers = new List<User1>();
        List<InfoV1> deleteInfoV1 = new List<InfoV1>();
        List<UserInfoV1> deleteUserInfoV1 = new List<UserInfoV1>();
        List<UserInfoV2> deleteUserInfoV2 = new List<UserInfoV2>();

        public DataHub8Context dataHub8Context = new DataHub8Context();

        int[] uniqueIndexesForDelete = new int[0];

        int[] uniqueIndexesForUpdate = new int[0];

        public int[] generatedUniqueIndexes(int count, int maxIndex, int[] uniqueIndexes)
        {
            uniqueIndexes = new int[count];
            Random random = new Random(startingPoint);
            for (int i = 0; i < count;)
            {
                bool uniqueValue = true;
                int newRandowValue = random.Next(0, maxIndex);
                for (int j = 0; j < i; j++)
                {
                    if (uniqueIndexes[j] == newRandowValue)
                    {
                        uniqueValue = false;
                        break;
                    }
                }

                if (uniqueValue)
                {
                    uniqueIndexes[i] = newRandowValue;
                    i++;
                }
            }
            
            startingPoint += 59;
            return uniqueIndexes;
        }
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatecomboBox.SelectedIndex = 3;

            MaintabControl.SelectedIndex = 2;
        }
        public int startingPoint = 1;        

        public bool processedRequest()
        {
            bool correctRequest = true;

            try { dataHub8Context.SaveChanges(); }
            catch { correctRequest = false; }

            return correctRequest;
        }

        public void UpdateGridViewChange(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            switch (UpdatecomboBox.SelectedIndex)
            {
                case 0:
                    dataGridView.Columns.Add("Id", "id");
                    dataGridView.Columns.Add("Type", "type");
                    dataGridView.Columns.Add("Value", "value");
                    dataGridView.Columns["Id"].Width = 129;
                    dataGridView.Columns["Type"].Width = 129;
                    dataGridView.Columns["Value"].Width = 129;
                    break;

                case 1:
                    dataGridView.Columns.Add("Id", "id");
                    dataGridView.Columns.Add("Title", "title");
                    dataGridView.Columns.Add("Login", "login");
                    dataGridView.Columns["Id"].Width = 129;
                    dataGridView.Columns["Title"].Width = 129;
                    dataGridView.Columns["Login"].Width = 129;
                    break;

                case 2:
                    dataGridView.Columns.Add("Id", "id");
                    dataGridView.Columns.Add("UserId", "userid");
                    dataGridView.Columns.Add("InfoId", "infoId");
                    dataGridView.Columns["Id"].Width = 129;
                    dataGridView.Columns["UserId"].Width = 129;
                    dataGridView.Columns["InfoId"].Width = 129;
                    break;

                case 3:
                    dataGridView.Columns.Add("Id", "id");
                    dataGridView.Columns.Add("UserId", "userid");
                    dataGridView.Columns.Add("Type", "type");
                    dataGridView.Columns.Add("Value", "value");
                    dataGridView.Columns["Id"].Width = 97;
                    dataGridView.Columns["UserId"].Width = 97;
                    dataGridView.Columns["Type"].Width = 97;
                    dataGridView.Columns["Value"].Width = 97;
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

        public User1 GenerateUser1()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string generatedTitle = GenerateStr(numberLength, symbolsKit);
            string generatedLogin = GenerateStr(numberLength, symbolsKit);

            User1 user1 = new User1 { Title = generatedTitle, Login = generatedLogin };
            startingPoint += 100;
            return user1;
        }

        public InfoV1 GenerateInfoV1()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string symbolsNumber = "0123456789";
            List<string> listType = (new string[] { "mail", "number", "link" }.ToList());
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
                generatedValue = "+7" + GenerateStr(numberLength, symbolsNumber);
            }
            else if (generatedType == "link")
            {
                generatedValue = "https://vk.com/" + GenerateStr(numberLength, symbolsKit);
            }

            InfoV1 infoV1 = new InfoV1 { Type = generatedType, Value = generatedValue };
            startingPoint += 100;
            return infoV1;
        }

        public UserInfoV1 GenerateUserInfoV1()
        {
            Random random = new Random(startingPoint);

            var users = dataHub8Context.User1s.ToList();
            int generatedIndexUsers = random.Next(0, users.Count);
            long generatedUserId = users[generatedIndexUsers].Id;  
            
            var infoV1s = dataHub8Context.InfoV1s.ToList();
            int generatedIndexInfoV1s = random.Next(0, infoV1s.Count);
            long generatedInfoId = infoV1s[generatedIndexInfoV1s].Id;


            UserInfoV1 userInfoV1 = new UserInfoV1 { UserId = generatedUserId, InfoId = generatedInfoId };
            startingPoint += 1;
            return userInfoV1;

        }

        public UserInfoV2 GenerateUserInfoV2()
        {
            Random random = new Random(startingPoint);
            int numberLength = 10;
            string symbolsKit = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string symbolsNumber = "0123456789";
            var users = dataHub8Context.User1s.ToList();
            int generatedIndexUsers = random.Next(0, users.Count);
            long generatedUserId = users[generatedIndexUsers].Id;

            List<string> listType = (new string[] { "mail", "number", "link" }.ToList());
            string generatedType = listType[new Random(startingPoint).Next(listType.Count)];
            string generatedValue = "";
            if (generatedType == "mail")
            {
                generatedValue = GenerateStr(numberLength, symbolsKit) + "@gmail.com";
            }
            else if (generatedType == "number")
            {
                generatedValue = "+7" + GenerateStr(numberLength, symbolsNumber);
            }
            else if (generatedType == "link")
            {
                generatedValue = "https://vk.com/" + GenerateStr(numberLength, symbolsKit);
            }
            UserInfoV2 userInfoV2 = new UserInfoV2 { UserId = generatedUserId, Type = generatedType, Value = generatedValue };
            startingPoint += 100;
            return userInfoV2;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ReaddataGridView.Rows.Clear();

            if (readComboBox.SelectedIndex == 0)
            {           
                List<InfoV1> infoV1 = dataHub8Context.InfoV1s.ToList();
                if (infoV1.Count < 1)
                {
                    MessageBox.Show("Таблица пустая");
                    return;
                }
                int quantityInfoV1 = Int32.Parse(readTextBox.Text);
                if (quantityInfoV1 > infoV1.Count)
                {
                    MessageBox.Show("Объём заданной выборки превышает размер коллекции");
                    return;
                }
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    ReaddataGridView.Rows.Add(infoV1[i].Id, infoV1[i].Type, infoV1[i].Value);
                }
            }

            else if (readComboBox.SelectedIndex == 1)
            {
                List<User1> user1 = dataHub8Context.User1s.ToList();
                if (user1.Count < 1)
                {
                    MessageBox.Show("Таблица пустая");
                    return;
                }
                int quantityUser1 = Int32.Parse(readTextBox.Text);
                if (quantityUser1 > user1.Count)
                {
                    MessageBox.Show("Объём заданной выборки превышает размер коллекции");
                    return;
                }
                for (int i = 0; i < quantityUser1; i++)
                {
                    ReaddataGridView.Rows.Add(user1[i].Id, user1[i].Title, user1[i].Login);
                }
            }

            else if (readComboBox.SelectedIndex == 2)
            {
                List<UserInfoV1> userInfo_v1 = dataHub8Context.UserInfoV1s.ToList();
                if (userInfo_v1.Count < 1)
                {
                    MessageBox.Show("Таблица пустая");
                    return;
                }
                int quantityUserInfoV1 = Int32.Parse(readTextBox.Text);
                if (quantityUserInfoV1 > userInfo_v1.Count)
                {
                    MessageBox.Show("Объём заданной выборки превышает размер коллекции");
                    return;
                }
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    ReaddataGridView.Rows.Add(userInfo_v1[i].Id, userInfo_v1[i].UserId, userInfo_v1[i].InfoId);
                }
            }

            else if (readComboBox.SelectedIndex == 3)
            {
                List<UserInfoV2> userInfo_v2 = dataHub8Context.UserInfoV2s.ToList();
                if (userInfo_v2.Count < 1)
                {
                    MessageBox.Show("Таблица пустая");
                    return;
                }
                int quantityUserInfoV2 = Int32.Parse(readTextBox.Text);
                if (quantityUserInfoV2 > userInfo_v2.Count)
                {
                    MessageBox.Show("Объём заданной выборки превышает размер коллекции");
                    return;
                }
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    ReaddataGridView.Rows.Add(userInfo_v2[i].Id, userInfo_v2[i].UserId, userInfo_v2[i].Type, userInfo_v2[i].Value);
                }
            }         
           
        }

        private void readComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReaddataGridView.Columns.Clear();
            ReaddataGridView.Rows.Clear();
            switch (readComboBox.SelectedIndex)
            {
                case 0:
                    ReaddataGridView.Columns.Add("Id", "id");
                    ReaddataGridView.Columns.Add("Type", "type");
                    ReaddataGridView.Columns.Add("Value", "value");
                    ReaddataGridView.Columns["Id"].Width = 258;
                    ReaddataGridView.Columns["Type"].Width = 258;
                    ReaddataGridView.Columns["Value"].Width = 258;
                    //DataGridViewColumn idColumn = ReaddataGridView.Columns["Id"];
                    //idColumn.Width = 250;
                    //DataGridViewColumn typeColumn = ReaddataGridView.Columns["Type"];
                    //typeColumn.Width = 250;
                    //DataGridViewColumn valueColumn = ReaddataGridView.Columns["Value"];
                    //valueColumn.Width = 250;
                    break;

                case 1:
                    ReaddataGridView.Columns.Add("Id", "id");
                    ReaddataGridView.Columns.Add("Title", "title");
                    ReaddataGridView.Columns.Add("Login", "login");
                    ReaddataGridView.Columns["Id"].Width = 258;
                    ReaddataGridView.Columns["Title"].Width = 258;
                    ReaddataGridView.Columns["Login"].Width = 258;
                    break;

                case 2:
                    ReaddataGridView.Columns.Add("Id", "id");
                    ReaddataGridView.Columns.Add("UserId", "userid");
                    ReaddataGridView.Columns.Add("InfoId", "infoId");
                    ReaddataGridView.Columns["Id"].Width = 258;
                    ReaddataGridView.Columns["UserId"].Width = 258;
                    ReaddataGridView.Columns["InfoId"].Width = 258;
                    break;

                case 3:
                    ReaddataGridView.Columns.Add("Id", "id");
                    ReaddataGridView.Columns.Add("UserId", "userid");
                    ReaddataGridView.Columns.Add("Type", "type");
                    ReaddataGridView.Columns.Add("Value", "value");
                    ReaddataGridView.Columns["Id"].Width = 193;
                    ReaddataGridView.Columns["UserId"].Width = 193;
                    ReaddataGridView.Columns["Type"].Width = 194;
                    ReaddataGridView.Columns["Value"].Width = 194;
                    break;
            }    
        }

        private void AddcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdddataGridView.Columns.Clear();
            AdddataGridView.Rows.Clear();
            switch (addComboBox.SelectedIndex)
            {
                case 0:
                    AdddataGridView.Columns.Add("Type", "type");
                    AdddataGridView.Columns.Add("Value", "value");
                    AdddataGridView.Columns["Type"].Width = 387;
                    AdddataGridView.Columns["Value"].Width = 387;                    
                    break;

                case 1:
                    AdddataGridView.Columns.Add("Title", "title");
                    AdddataGridView.Columns.Add("Login", "login");
                    AdddataGridView.Columns["Title"].Width = 387;
                    AdddataGridView.Columns["Login"].Width = 387;
                    break;

                case 2:
                    AdddataGridView.Columns.Add("UserId", "userid");
                    AdddataGridView.Columns.Add("InfoId", "infoId");
                    AdddataGridView.Columns["UserId"].Width = 387;
                    AdddataGridView.Columns["InfoId"].Width = 387;
                    break;

                case 3:
                    AdddataGridView.Columns.Add("UserId", "userid");
                    AdddataGridView.Columns.Add("Type", "type");
                    AdddataGridView.Columns.Add("Value", "value");
                    AdddataGridView.Columns["UserId"].Width = 258;
                    AdddataGridView.Columns["Type"].Width = 258;
                    AdddataGridView.Columns["Value"].Width = 258;
                    break;

            }   
        }

        private void UpdatecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridViewChange(OlddataGridView);
            UpdateGridViewChange(NewdataGridView);        
        }

        private void DeletecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeletedataGridView.Columns.Clear();
            DeletedataGridView.Rows.Clear();
            switch (DeletecomboBox.SelectedIndex)
            {
                case 0:
                    DeletedataGridView.Columns.Add("Id", "id");
                    DeletedataGridView.Columns.Add("Type", "type");
                    DeletedataGridView.Columns.Add("Value", "value");
                    DeletedataGridView.Columns["Id"].Width = 258;
                    DeletedataGridView.Columns["Type"].Width = 258;
                    DeletedataGridView.Columns["Value"].Width = 258;
                    //DataGridViewColumn idColumn = ReaddataGridView.Columns["Id"];
                    //idColumn.Width = 250;
                    //DataGridViewColumn typeColumn = ReaddataGridView.Columns["Type"];
                    //typeColumn.Width = 250;
                    //DataGridViewColumn valueColumn = ReaddataGridView.Columns["Value"];
                    //valueColumn.Width = 250;
                    break;

                case 1:
                    DeletedataGridView.Columns.Add("Id", "id");
                    DeletedataGridView.Columns.Add("Title", "title");
                    DeletedataGridView.Columns.Add("Login", "login");
                    DeletedataGridView.Columns["Id"].Width = 258;
                    DeletedataGridView.Columns["Title"].Width = 258;
                    DeletedataGridView.Columns["Login"].Width = 258;
                    break;

                case 2:
                    DeletedataGridView.Columns.Add("Id", "id");
                    DeletedataGridView.Columns.Add("UserId", "userid");
                    DeletedataGridView.Columns.Add("InfoId", "infoId");
                    DeletedataGridView.Columns["Id"].Width = 258;
                    DeletedataGridView.Columns["UserId"].Width = 258;
                    DeletedataGridView.Columns["InfoId"].Width = 258;
                    break;

                case 3:
                    DeletedataGridView.Columns.Add("Id", "id");
                    DeletedataGridView.Columns.Add("UserId", "userid");
                    DeletedataGridView.Columns.Add("Type", "type");
                    DeletedataGridView.Columns.Add("Value", "value");
                    DeletedataGridView.Columns["Id"].Width = 193;
                    DeletedataGridView.Columns["UserId"].Width = 193;
                    DeletedataGridView.Columns["Type"].Width = 194;
                    DeletedataGridView.Columns["Value"].Width = 194;
                    break;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //Отлавливаем пустоту списка
            if (addComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите таблицу", "Сообщение");
                return;
            }

            if (addComboBox.SelectedIndex == 0)
            {
                //Отлавливаем пустоту списка
                if (generatedInfoV1.Count == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте выборку", "Сообщение");
                    return;
                }

                int quantityInfoV1 = Int32.Parse(addTextBox.Text);

                for (int i = 0; i < quantityInfoV1; i++)
                {
                    dataHub8Context.InfoV1s.AddRange(generatedInfoV1[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequest = processedRequest();

                if (correctRequest)
                {
                    MessageBox.Show("Данные были успешно занесены", "Сообщение");
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при занесении данных", "Сообщение");
                }
                
                generatedInfoV1 = new List<InfoV1>();
                AdddataGridView.Rows.Clear();
            }
            

            else if (addComboBox.SelectedIndex == 1)
            {
                //Отлавливаем пустоту списка
                if (generatedUsers.Count == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте выборку", "Сообщение");
                    return;
                }

                int quantityUser1 = Int32.Parse(addTextBox.Text);

                for (int i = 0; i < quantityUser1; i++)
                {
                    dataHub8Context.User1s.AddRange(generatedUsers[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequest = processedRequest();

                if (correctRequest)
                {
                    MessageBox.Show("Данные были успешно занесены", "Сообщение");
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при занесении данных", "Сообщение");
                }

                generatedUsers = new List<User1>();
                AdddataGridView.Rows.Clear();
            }

            else if (addComboBox.SelectedIndex == 2)
            {                
                //Отлавливаем пустоту списка
                if (generatedUserInfoV1.Count == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте выборку", "Сообщение");
                    return;
                }                

                int quantityUserInfoV1 = Int32.Parse(addTextBox.Text);

                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    dataHub8Context.UserInfoV1s.AddRange(generatedUserInfoV1[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequest = processedRequest();

                if (correctRequest)
                {
                    MessageBox.Show("Данные были успешно занесены", "Сообщение");
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при занесении данных", "Сообщение");
                }

                generatedUserInfoV1 = new List<UserInfoV1>();
                AdddataGridView.Rows.Clear();
            }

            else if (addComboBox.SelectedIndex == 3)
            {                
                //Отлавливаем пустоту списка
                if (generatedUserInfoV2.Count == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте выборку", "Сообщение");
                    return;
                }

                int quantityUserInfoV2 = Int32.Parse(addTextBox.Text);

                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    dataHub8Context.UserInfoV2s.AddRange(generatedUserInfoV2[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequest = processedRequest();

                if (correctRequest)
                {
                    MessageBox.Show("Данные были успешно занесены", "Сообщение");
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при занесении данных", "Сообщение");
                }

                generatedUserInfoV2 = new List<UserInfoV2>();
                AdddataGridView.Rows.Clear();
            }

        }

        private bool CheckForDuplicates()
        {

            for (int i = 0; i < DeletedataGridView.RowCount; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < DeletedataGridView.ColumnCount; j++)
                {
                    if (list.Contains((int)DeletedataGridView[i, j].Value))
                    {
                        return true;
                    }
                    list.Add((int)DeletedataGridView[i, j].Value);
                }
            }
            return false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int quantityInfoV1 = uniqueIndexesForDelete.Length;
            int quantityUser1 = uniqueIndexesForDelete.Length;
            int quantityUserInfoV1 = uniqueIndexesForDelete.Length;
            int quantityUserInfoV2 = uniqueIndexesForDelete.Length;

            if (quantityInfoV1 == 0)
            {
                MessageBox.Show("Сначала сгенерируйте выборку", "Сообщение");
                return;
            }

            switch (DeletecomboBox.SelectedIndex)
            {
                case 0:
                    var infov1s = dataHub8Context.InfoV1s.ToList();

                    //Удаляем строки таблицы в цикле
                    for (int i = 0; i < quantityInfoV1; i++)
                    {                        
                        dataHub8Context.InfoV1s.Remove(infov1s[uniqueIndexesForDelete[i]]);
                    }

                    //Проверяем корректность отрабатывания SaveChanges
                    bool correctRequestInfoV1 = processedRequest();

                    if (correctRequestInfoV1)
                    {
                        MessageBox.Show("Данные были успешно удалены", "Сообщение");
                        DeletedataGridView.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка при удалении данных", "Сообщение");
                    }
                    break;

                case 1:
                    var user1s = dataHub8Context.User1s.ToList();

                    //Удаляем строки таблицы в цикле
                    for (int i = 0; i < quantityUser1; i++)
                    {
                        dataHub8Context.User1s.Remove(user1s[uniqueIndexesForDelete[i]]);
                    }

                    //Проверяем корректность отрабатывания SaveChanges
                    bool correctRequestUser1 = processedRequest();

                    if (correctRequestUser1)
                    {
                        MessageBox.Show("Данные были успешно удалены", "Сообщение");
                        DeletedataGridView.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка при удалении данных", "Сообщение");
                    }
                    break;                    

                case 2:
                    var userInfov1s = dataHub8Context.UserInfoV1s.ToList();
                    var user1 = dataHub8Context.User1s.ToList();
                    var infoV1 = dataHub8Context.InfoV1s.ToList();

                    if (deleteUsers.Count > 0)
                    {
                        deleteUsers = new List<User1>();
                    }

                    if(deleteInfoV1.Count > 0)
                    {
                        deleteInfoV1 = new List<InfoV1>();
                    }

                    //Заносим список User'ов перед удалением
                    //(на которые ссылаются выборочные UserInfo_V1)
                    for (int i = 0; i < quantityUserInfoV1; i++)
                    {
                        long idUserDeleted = userInfov1s[uniqueIndexesForDelete[i]].UserId;
                        long idInfoV1Deleted = userInfov1s[uniqueIndexesForDelete[i]].InfoId;
                        for (int j = 0; j < user1.Count; j++)
                        {
                            if (user1[j].Id == idUserDeleted)
                            {
                                deleteUsers.Add(user1[j]);
                            }
                        }
                        for(int j = 0; j < infoV1.Count; j++)
                        {
                            if (infoV1[j].Id == idInfoV1Deleted)
                            {
                                deleteInfoV1.Add(infoV1[j]);
                            }
                        }
                    }

                    //Удаляем строки таблицы в цикле
                    for (int i = 0; i < quantityUserInfoV1; i++)
                    {
                        dataHub8Context.UserInfoV1s.Remove(userInfov1s[uniqueIndexesForDelete[i]]);
                    }

                    //Проверяем корректность отрабатывания SaveChanges
                    bool correctRequestUserInfoV1 = processedRequest();

                    if (correctRequestUserInfoV1)
                    {
                        MessageBox.Show("Данные были успешно удалены", "Сообщение");
                        DeletedataGridView.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка при удалении данных", "Сообщение");
                    }
                    break;                    

                case 3:
                    var userInfov2 = dataHub8Context.UserInfoV2s.ToList();
                    var users = dataHub8Context.User1s.ToList();

                    if(deleteUsers.Count > 0 )
                    {
                        deleteUsers = new List<User1>();
                    }

                    //Заносим список User'ов перед удалением
                    //(на которые ссылаются выборочные UserInfo_V2)
                    for (int i = 0; i < quantityUserInfoV2; i++)
                    {
                        long idUserDeleted = userInfov2[uniqueIndexesForDelete[i]].UserId;
                        for (int j = 0; j < users.Count; j++)
                        {
                            if (users[j].Id == idUserDeleted)
                            {
                                deleteUsers.Add(users[j]);
                            }
                        }
                    }

                    //Удаляем User'ов, на которые ссылаются quantityUserInfoV2
                    for (int i = 0; i < quantityUserInfoV2; i++)
                    {
                        dataHub8Context.User1s.Remove(deleteUsers[i]);
                    }

                    //Очищаем список улдаляемых User'ов
                    deleteUsers = new List<User1>();

                    //Удаляем строки таблицы в цикле
                    for (int i = 0; i < quantityUserInfoV2; i++)
                    {
                        dataHub8Context.UserInfoV2s.Remove(userInfov2[uniqueIndexesForDelete[i]]);
                    }

                    //Проверяем корректность отрабатывания SaveChanges
                    bool correctRequestUserInfoV2 = processedRequest();

                    if (correctRequestUserInfoV2)
                    {
                        MessageBox.Show("Данные были успешно удалены", "Сообщение");
                        DeletedataGridView.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка при удалении данных", "Сообщение");
                    }
                    break;                  


            }
            DeletedataGridView.Rows.Clear();
            uniqueIndexesForDelete = new int[0];

        }


        private void GenerateDeleteButton_Click(object sender, EventArgs e)
        {
            //Отлавливаем пустоту comboBox
            if (DeletecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите таблицу", "Сообщение");
                return;
            }

            DeletedataGridView.Rows.Clear();

            if (DeletecomboBox.SelectedIndex == 0)
            {              
                
                int quantityInfoV1 = Int32.Parse(deleteTextBox.Text);

                if (dataHub8Context.InfoV1s.Count() < quantityInfoV1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<InfoV1> deleteInfoV1 = dataHub8Context.InfoV1s.ToList();

                uniqueIndexesForDelete = generatedUniqueIndexes(quantityInfoV1, deleteInfoV1.Count, uniqueIndexesForDelete);

                for (int i = 0; i < quantityInfoV1; i++)
                {
                    int currentIndex = uniqueIndexesForDelete[i];
                    DeletedataGridView.Rows.Add(deleteInfoV1[currentIndex].Id, deleteInfoV1[currentIndex].Type, deleteInfoV1[currentIndex].Value);
                }

            }

            else if (DeletecomboBox.SelectedIndex == 1)
            {
                int quantityUser1 = Int32.Parse(deleteTextBox.Text);

                if (dataHub8Context.InfoV1s.Count() < quantityUser1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<User1> deleteUser1 = dataHub8Context.User1s.ToList();

                uniqueIndexesForDelete = generatedUniqueIndexes(quantityUser1, deleteUser1.Count, uniqueIndexesForDelete);

                for (int i = 0; i < quantityUser1; i++)
                {
                    int currentIndex = uniqueIndexesForDelete[i];
                    DeletedataGridView.Rows.Add(deleteUser1[currentIndex].Id, deleteUser1[currentIndex].Title, deleteUser1[currentIndex].Login);
                }
            }

            else if (DeletecomboBox.SelectedIndex == 2)
            {
                int quantityUserInfoV1 = Int32.Parse(deleteTextBox.Text);

                if (dataHub8Context.UserInfoV1s.Count() < quantityUserInfoV1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<UserInfoV1> deleteUserInfoV1 = dataHub8Context.UserInfoV1s.ToList();

                uniqueIndexesForDelete = generatedUniqueIndexes(quantityUserInfoV1, deleteUserInfoV1.Count, uniqueIndexesForDelete);

                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    int currentIndex = uniqueIndexesForDelete[i];
                    DeletedataGridView.Rows.Add(deleteUserInfoV1[currentIndex].Id, deleteUserInfoV1[currentIndex].UserId, deleteUserInfoV1[currentIndex].InfoId);
                }
            }

            else if (DeletecomboBox.SelectedIndex == 3)
            {
                int quantityUserInfoV2 = Int32.Parse(deleteTextBox.Text);

                if (dataHub8Context.UserInfoV2s.Count() < quantityUserInfoV2)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<UserInfoV2> deleteUserInfoV2 = dataHub8Context.UserInfoV2s.ToList();

                uniqueIndexesForDelete = generatedUniqueIndexes(quantityUserInfoV2, deleteUserInfoV2.Count, uniqueIndexesForDelete);

                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    int currentIndex = uniqueIndexesForDelete[i];
                    DeletedataGridView.Rows.Add(deleteUserInfoV2[currentIndex].Id, deleteUserInfoV2[currentIndex].UserId, deleteUserInfoV2[currentIndex].Type, deleteUserInfoV2[currentIndex].Value);
                }
            }
        }

        private void generateAddButton_Click(object sender, EventArgs e)
        {
            //Отлавливаем пустоту списка
            if (addComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите таблицу", "Сообщение");
                return;
            }

            AdddataGridView.Rows.Clear();

            if (addComboBox.SelectedIndex == 0)
            {
                //Чистим список со сгенерированными данными, если он не пуст
                if (generatedInfoV1.Count != 0) generatedInfoV1 = new List<InfoV1>();

                //Количество экземпляров
                int quantityInfoV1 = Int32.Parse(addTextBox.Text);

                //Генерим InfoV1 в цикле
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    generatedInfoV1.Add(GenerateInfoV1());
                }
                
                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    AdddataGridView.Rows.Add(generatedInfoV1[i].Type, generatedInfoV1[i].Value);
                }

            }


            else if (addComboBox.SelectedIndex == 1)
            {
                //Чистим список со сгенерированными данными, если он не пуст
                if (generatedUsers.Count != 0) generatedUsers = new List<User1>();

                //Количество экземпляров
                int quantityUser1 = Int32.Parse(addTextBox.Text);

                //Генерим InfoV1 в цикле
                for (int i = 0; i < quantityUser1; i++)
                {
                    generatedUsers.Add(GenerateUser1());
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUser1; i++)
                {
                    AdddataGridView.Rows.Add(generatedUsers[i].Title, generatedUsers[i].Login);
                }
            }

            else if (addComboBox.SelectedIndex == 2)
            {
                var infoV1 = dataHub8Context.InfoV1s.ToList();
                var user1 = dataHub8Context.User1s.ToList();
                //Чистим список со сгенерированными данными, если он не пуст
                if (generatedUserInfoV1.Count != 0) generatedUserInfoV1 = new List<UserInfoV1>();

                //Количество экземпляров
                int quantityUserInfoV1 = Int32.Parse(addTextBox.Text);

                if (infoV1.Count == 0 || user1.Count == 0)
                {
                    MessageBox.Show("Сначала добавьте данные в связанные таблицы");
                    return;
                }

                //Генерим InfoV1 в цикле
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    generatedUserInfoV1.Add(GenerateUserInfoV1());
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    AdddataGridView.Rows.Add(generatedUserInfoV1[i].UserId, generatedUserInfoV1[i].InfoId);
                }
            }

            else if (addComboBox.SelectedIndex == 3)
            {
                var user1 = dataHub8Context.User1s.ToList();
                //Чистим список со сгенерированными данными, если он не пуст
                if (generatedUserInfoV2.Count != 0) generatedUserInfoV2 = new List<UserInfoV2>();

                //Количество экземпляров
                int quantityUserInfoV2 = Int32.Parse(addTextBox.Text);

                if (user1.Count == 0)
                {
                    MessageBox.Show("Сначала добавьте данные в таблицу под названием \"User_1\"");
                    return;
                }

                //Генерим InfoV1 в цикле
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    generatedUserInfoV2.Add(GenerateUserInfoV2());
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    AdddataGridView.Rows.Add(generatedUserInfoV2[i].UserId, generatedUserInfoV2[i].Type, generatedUserInfoV2[i].Value);
                }
            }

        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            switch(DeletecomboBox.SelectedIndex)
            {
                case 0:
                {
                    var infov1s = dataHub8Context.InfoV1s.ToList();
                    var userInfoV1 = dataHub8Context.UserInfoV1s.ToList();
                        //Удаляем строки таблицы в цикле
                        for (int i = 0; i < userInfoV1.Count; i++)
                    {
                        dataHub8Context.UserInfoV1s.Remove(userInfoV1[i]);
                    }

                        
                        for (int i = 0; i < infov1s.Count; i++)
                    {
                        dataHub8Context.InfoV1s.Remove(infov1s[i]);
                    }

                        

                        //Проверяем корректность отрабатывания SaveChanges
                        bool correctRequest = processedRequest();

                    if (correctRequest)
                    {
                        MessageBox.Show("Данные были успешно очищены", "Сообщение");
                        DeletedataGridView.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка при очищении данных", "Сообщение");
                    }

                    break;
                }

                case 1:
                    {
                        var users = dataHub8Context.User1s.ToList();
                        var userInfoV1 = dataHub8Context.UserInfoV1s.ToList();
                        var userInfoV2 = dataHub8Context.UserInfoV2s.ToList();

                        //Удаляем ссылки на объекты              
                        for (int i = 0; i < userInfoV1.Count; i++)
                        {
                            dataHub8Context.UserInfoV1s.Remove(userInfoV1[i]);
                        }

                        for (int i = 0; i < userInfoV2.Count; i++)
                        {
                            dataHub8Context.UserInfoV2s.Remove(userInfoV2[i]);
                        }

                        //Удаляем User'ов
                        for (int i = 0; i < users.Count; i++)
                        {
                            dataHub8Context.User1s.Remove(users[i]);
                        }

                        //Проверяем корректность отрабатывания SaveChanges
                        bool correctRequest = processedRequest();

                        if (correctRequest)
                        {
                            MessageBox.Show("Данные были успешно очищены", "Сообщение");
                            DeletedataGridView.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Возникла ошибка при очищении данных", "Сообщение");
                        }

                        break;
                    }

                case 2:
                    {
                        var userInfov1s = dataHub8Context.UserInfoV1s.ToList();

                        //Удаляем строки таблицы в цикле
                        for (int i = 0; i < userInfov1s.Count; i++)
                        {
                            dataHub8Context.UserInfoV1s.Remove(userInfov1s[i]);
                        }

                        //Проверяем корректность отрабатывания SaveChanges
                        bool correctRequest = processedRequest();

                        if (correctRequest)
                        {
                            MessageBox.Show("Данные были успешно очищены", "Сообщение");
                            DeletedataGridView.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Возникла ошибка при очищении данных", "Сообщение");
                        }

                        break;
                    }

                case 3:
                    {
                        var userInfov2s = dataHub8Context.UserInfoV2s.ToList();

                        //Удаляем строки таблицы в цикле
                        for (int i = 0; i < userInfov2s.Count; i++)
                        {
                            dataHub8Context.UserInfoV2s.Remove(userInfov2s[i]);
                        }

                        //Проверяем корректность отрабатывания SaveChanges
                        bool correctRequest = processedRequest();

                        if (correctRequest)
                        {
                            MessageBox.Show("Данные были успешно очищены", "Сообщение");
                            DeletedataGridView.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Возникла ошибка при очищении данных", "Сообщение");
                        }

                        break;
                    }
            }
        }

        private void GenerateUpdatebutton_Click(object sender, EventArgs e)
        {
            if (UpdatecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите таблицу", "Сообщение");
                return;
            }
            OlddataGridView.Rows.Clear();
            NewdataGridView.Rows.Clear();


            if (UpdatecomboBox.SelectedIndex == 0)
            {

                int quantityInfoV1 = Int32.Parse(updateTextBox.Text);

                if (dataHub8Context.InfoV1s.Count() < quantityInfoV1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<InfoV1> infoV1 = dataHub8Context.InfoV1s.ToList();

                uniqueIndexesForUpdate = generatedUniqueIndexes(quantityInfoV1, infoV1.Count, uniqueIndexesForUpdate);



                //Чистим списки со сгенерированными и обновляемыми данными, если они не пусты
                if (updateInfoV1.Count != 0) updateInfoV1= new List<InfoV1>();
                if (updateInfoV1.Count != 0) updateInfoV1 = new List<InfoV1>();

                //Генерим User1 в цикле
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    updateInfoV1.Add(GenerateInfoV1());
                }

                //переносим Idшники из таблицы в сгенерированный список
                for (int i = 0; i < uniqueIndexesForUpdate.Length; i++)
                {
                    updateInfoV1[i].Id = infoV1[uniqueIndexesForUpdate[i]].Id;
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    int currentIndex = uniqueIndexesForUpdate[i];
                    OlddataGridView.Rows.Add(infoV1[currentIndex].Id, infoV1[currentIndex].Type, infoV1[currentIndex].Value);
                    NewdataGridView.Rows.Add(updateInfoV1[i].Id, updateInfoV1[i].Type, updateInfoV1[i].Value);
                }
            }

            if (UpdatecomboBox.SelectedIndex == 1)
            {

                int quantityUser1 = Int32.Parse(updateTextBox.Text);

                if (dataHub8Context.User1s.Count() < quantityUser1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<User1> user1 = dataHub8Context.User1s.ToList();

                uniqueIndexesForUpdate = generatedUniqueIndexes(quantityUser1, user1.Count, uniqueIndexesForUpdate);



                //Чистим списки со сгенерированными и обновляемыми данными, если они не пусты
                if (updateUsers.Count != 0) updateUsers = new List<User1>();
                if (updateUsers.Count != 0) updateUsers = new List<User1>();

                //Генерим User1 в цикле
                for (int i = 0; i < quantityUser1; i++)
                {
                    updateUsers.Add(GenerateUser1());
                }

                //переносим Idшники из таблицы в сгенерированный список
                for (int i = 0; i < uniqueIndexesForUpdate.Length; i++)
                {
                    updateUsers[i].Id = user1[uniqueIndexesForUpdate[i]].Id;
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUser1; i++)
                {
                    int currentIndex = uniqueIndexesForUpdate[i];
                    OlddataGridView.Rows.Add(user1[currentIndex].Id, user1[currentIndex].Title, user1[currentIndex].Login);
                    NewdataGridView.Rows.Add(updateUsers[i].Id, updateUsers[i].Title, updateUsers[i].Login);
                }
            }

            if (UpdatecomboBox.SelectedIndex == 2)
            {

                int quantityUserInfoV1 = Int32.Parse(updateTextBox.Text);

                if (dataHub8Context.UserInfoV1s.Count() < quantityUserInfoV1)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<UserInfoV1> userInfoV1 = dataHub8Context.UserInfoV1s.ToList();

                uniqueIndexesForUpdate = generatedUniqueIndexes(quantityUserInfoV1, userInfoV1.Count, uniqueIndexesForUpdate);



                //Чистим списки со сгенерированными и обновляемыми данными, если они не пусты
                if (updateUserInfoV1.Count != 0) updateUserInfoV1 = new List<UserInfoV1>();
                if (updateUserInfoV1.Count != 0) updateUserInfoV1 = new List<UserInfoV1>();

                //Генерим UserInfoV2 в цикле
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    updateUserInfoV1.Add(GenerateUserInfoV1());
                }

                //переносим Idшники из таблицы в сгенерированный список
                for (int i = 0; i < uniqueIndexesForUpdate.Length; i++)
                {
                    updateUserInfoV1[i].Id = userInfoV1[uniqueIndexesForUpdate[i]].Id;
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    int currentIndex = uniqueIndexesForUpdate[i];
                    OlddataGridView.Rows.Add(userInfoV1[currentIndex].Id, userInfoV1[currentIndex].UserId, userInfoV1[currentIndex].InfoId);
                    NewdataGridView.Rows.Add(updateUserInfoV1[i].Id, updateUserInfoV1[i].UserId, updateUserInfoV1[i].InfoId);
                }
            }

            if (UpdatecomboBox.SelectedIndex == 3)
            {

                int quantityUserInfoV2 = Int32.Parse(updateTextBox.Text);

                if (dataHub8Context.UserInfoV2s.Count() < quantityUserInfoV2)
                {
                    MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
                    return;
                }

                List<UserInfoV2> userInfoV2 = dataHub8Context.UserInfoV2s.ToList();

                uniqueIndexesForUpdate = generatedUniqueIndexes(quantityUserInfoV2, userInfoV2.Count, uniqueIndexesForUpdate);



                //Чистим списки со сгенерированными и обновляемыми данными, если они не пусты
                if (updateUserInfoV2.Count != 0) updateUserInfoV2 = new List<UserInfoV2>();
                if (updateUserInfoV2.Count != 0) updateUserInfoV2 = new List<UserInfoV2>();

                //Генерим UserInfoV2 в цикле
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    updateUserInfoV2.Add(GenerateUserInfoV2());
                }

                //переносим Idшники из таблицы в сгенерированный список
                for (int i = 0; i < uniqueIndexesForUpdate.Length; i++)
                {
                    updateUserInfoV2[i].Id = userInfoV2[uniqueIndexesForUpdate[i]].Id;
                }

                //Выводим сгенерированные данные в DataGridView
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    int currentIndex = uniqueIndexesForUpdate[i];
                    OlddataGridView.Rows.Add(userInfoV2[currentIndex].Id, userInfoV2[currentIndex].UserId, userInfoV2[currentIndex].Type, userInfoV2[currentIndex].Value);
                    NewdataGridView.Rows.Add(updateUserInfoV2[i].Id, updateUserInfoV2[i].UserId, updateUserInfoV2[i].Type, updateUserInfoV2[i].Value);
                }     
            }
        }
        
        private void Updatebutton_Click(object sender, EventArgs e)
        {           
            if (UpdatecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите таблицу", "Сообщение");
                return;
            }

            if (UpdatecomboBox.SelectedIndex == 0)

            {
                int quantityInfoV1 = updateInfoV1.Count;

                var infov1s = dataHub8Context.InfoV1s.ToList();

                //Заменяем элементы в коллекции ToList
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    infov1s[i].Type = updateInfoV1[i].Type;
                    infov1s[i].Value = updateInfoV1[i].Value;
                }

                //Совершаем Update для DbSet
                for (int i = 0; i < quantityInfoV1; i++)
                {
                    dataHub8Context.InfoV1s.Update(infov1s[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequestInfoV1 = processedRequest();

                if (correctRequestInfoV1)
                {
                    MessageBox.Show("Данные были успешно обновлены", "Сообщение");
                    DeletedataGridView.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при обновлении данных", "Сообщение");
                }
            }

            if (UpdatecomboBox.SelectedIndex == 1)
            {
                int quantityUser1 = updateUsers.Count;

                var user1s = dataHub8Context.User1s.ToList();

                //Заменяем элементы в коллекции ToList
                for (int i = 0; i < quantityUser1; i++)
                {
                    user1s[i].Title = updateUsers[i].Title;
                    user1s[i].Login = updateUsers[i].Login;
                }

                //Совершаем Update для DbSet
                for (int i = 0; i < quantityUser1; i++)
                {
                    dataHub8Context.User1s.Update(user1s[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequestUser1 = processedRequest();

                if (correctRequestUser1)
                {
                    MessageBox.Show("Данные были успешно обновлены", "Сообщение");
                    DeletedataGridView.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при обновлении данных", "Сообщение");
                }
            }

            if (UpdatecomboBox.SelectedIndex == 2)
            {
                int quantityUserInfoV1 = updateUserInfoV1.Count;

                var userInfov1s = dataHub8Context.UserInfoV1s.ToList();

                //Заменяем элементы в коллекции ToList
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    userInfov1s[i].UserId = updateUserInfoV1[i].UserId;
                    userInfov1s[i].InfoId = updateUserInfoV1[i].InfoId;
                }

                //Совершаем Update для DbSet
                for (int i = 0; i < quantityUserInfoV1; i++)
                {
                    dataHub8Context.UserInfoV1s.Update(userInfov1s[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequestUserInfoV1 = processedRequest();

                if (correctRequestUserInfoV1)
                {
                    MessageBox.Show("Данные были успешно обновлены", "Сообщение");
                    DeletedataGridView.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при обновлении данных", "Сообщение");
                }
            }

            if (UpdatecomboBox.SelectedIndex == 3)
            {
                int quantityUserInfoV2 = updateUserInfoV2.Count;

                var userInfov2s = dataHub8Context.UserInfoV2s.ToList();

                //Заменяем элементы в коллекции ToList
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    userInfov2s[i].UserId = updateUserInfoV2[i].UserId;
                    userInfov2s[i].Type = updateUserInfoV2[i].Type;
                    userInfov2s[i].Value = updateUserInfoV2[i].Value;
                }

                //Совершаем Update для DbSet
                for (int i = 0; i < quantityUserInfoV2; i++)
                {
                    dataHub8Context.UserInfoV2s.Update(userInfov2s[i]);
                }

                //Проверяем корректность отрабатывания SaveChanges
                bool correctRequestUserInfoV2 = processedRequest();

                if (correctRequestUserInfoV2)
                {
                    MessageBox.Show("Данные были успешно обновлены", "Сообщение");
                    DeletedataGridView.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при обновлении данных", "Сообщение");
                }
            }
        }
    }
}