////using GenerateEntityWinForms;

//private void GenerateDeleteButton_Click(object sender, EventArgs e)
//{
//    //Отлавливаем пустоту comboBox
//    if (DeletecomboBox.SelectedIndex == -1)
//    {
//        MessageBox.Show("Сначала выберите таблицу", "Сообщение");
//        return;
//    }

//    DeletedataGridView.Rows.Clear();

//    if (DeletecomboBox.SelectedIndex == 0)
//    {

//        int quantityInfoV1 = Int32.Parse(deleteTextBox.Text);

//        if (dataHub8Context.InfoV1s.Count() < quantityInfoV1)
//        {
//            MessageBox.Show("Объём выборки меньше количества строк в таблице", "Сообщение");
//            return;
//        }

//        List<InfoV1> deleteInfoV1 = dataHub8Context.InfoV1s.ToList();

//        int[] UniqueIndexes = generatedUniqueIndexes(quantityInfoV1, deleteInfoV1.Count, uniqueIndexesForDelete);

//        for (int i = 0; i < quantityInfoV1; i++)
//        {
//            int currentIndex = uniqueIndexesForDelete[i];
//            DeletedataGridView.Rows.Add(deleteInfoV1[currentIndex].Id, deleteInfoV1[currentIndex].Type, deleteInfoV1[currentIndex].Value);
//        }

//    }

//    else if (DeletecomboBox.SelectedIndex == 1)
//    {
//        List<User1> user1 = dataHub8Context.User1s.ToList();
//        int quantityUser1 = Int32.Parse(deleteTextBox.Text);
//        for (int i = 0; i < quantityUser1; i++)
//        {
//            DeletedataGridView.Rows.Add(user1[i].Id, user1[i].Title, user1[i].Login);
//        }
//    }

//    else if (DeletecomboBox.SelectedIndex == 2)
//    {
//        List<UserInfoV1> userInfo_v1 = dataHub8Context.UserInfoV1s.ToList();
//        int quantityUserInfoV1 = Int32.Parse(deleteTextBox.Text);
//        for (int i = 0; i < quantityUserInfoV1; i++)
//        {
//            DeletedataGridView.Rows.Add(userInfo_v1[i].Id, userInfo_v1[i].UserId, userInfo_v1[i].InfoId);
//        }
//    }

//    else if (DeletecomboBox.SelectedIndex == 3)
//    {
//        List<UserInfoV2> userInfo_v2 = dataHub8Context.UserInfoV2s.ToList();
//        int quantityUserInfoV2 = Int32.Parse(deleteTextBox.Text);
//        for (int i = 0; i < quantityUserInfoV2; i++)
//        {
//            DeletedataGridView.Rows.Add(userInfo_v2[i].Id, userInfo_v2[i].UserId, userInfo_v2[i].Type, userInfo_v2[i].Value);
//        }
//    }
//}