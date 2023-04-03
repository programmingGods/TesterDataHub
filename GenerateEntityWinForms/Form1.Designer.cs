namespace GenerateEntityWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Readbutton = new System.Windows.Forms.Button();
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.ReadtabPage = new System.Windows.Forms.TabPage();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.readComboBox = new System.Windows.Forms.ComboBox();
            this.ReaddataGridView = new System.Windows.Forms.DataGridView();
            this.AddtabPage = new System.Windows.Forms.TabPage();
            this.generateAddButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.addComboBox = new System.Windows.Forms.ComboBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.AdddataGridView = new System.Windows.Forms.DataGridView();
            this.ChangestabPage = new System.Windows.Forms.TabPage();
            this.GenerateUpdatebutton = new System.Windows.Forms.Button();
            this.UpdatecomboBox = new System.Windows.Forms.ComboBox();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.NewdataGridView = new System.Windows.Forms.DataGridView();
            this.OlddataGridView = new System.Windows.Forms.DataGridView();
            this.DeletetabPage = new System.Windows.Forms.TabPage();
            this.deleteAll = new System.Windows.Forms.Button();
            this.GenerateDeleteButton = new System.Windows.Forms.Button();
            this.DeletecomboBox = new System.Windows.Forms.ComboBox();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.DeletedataGridView = new System.Windows.Forms.DataGridView();
            this.MaintabControl.SuspendLayout();
            this.ReadtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaddataGridView)).BeginInit();
            this.AddtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdddataGridView)).BeginInit();
            this.ChangestabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlddataGridView)).BeginInit();
            this.DeletetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Readbutton
            // 
            this.Readbutton.Location = new System.Drawing.Point(811, 73);
            this.Readbutton.Name = "Readbutton";
            this.Readbutton.Size = new System.Drawing.Size(249, 31);
            this.Readbutton.TabIndex = 0;
            this.Readbutton.Text = "Прочитать данные";
            this.Readbutton.UseVisualStyleBackColor = true;
            this.Readbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaintabControl
            // 
            this.MaintabControl.Controls.Add(this.ReadtabPage);
            this.MaintabControl.Controls.Add(this.AddtabPage);
            this.MaintabControl.Controls.Add(this.ChangestabPage);
            this.MaintabControl.Controls.Add(this.DeletetabPage);
            this.MaintabControl.Location = new System.Drawing.Point(12, 12);
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(1074, 514);
            this.MaintabControl.TabIndex = 1;
            // 
            // ReadtabPage
            // 
            this.ReadtabPage.Controls.Add(this.readTextBox);
            this.ReadtabPage.Controls.Add(this.readComboBox);
            this.ReadtabPage.Controls.Add(this.ReaddataGridView);
            this.ReadtabPage.Controls.Add(this.Readbutton);
            this.ReadtabPage.Location = new System.Drawing.Point(4, 29);
            this.ReadtabPage.Name = "ReadtabPage";
            this.ReadtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReadtabPage.Size = new System.Drawing.Size(1066, 481);
            this.ReadtabPage.TabIndex = 0;
            this.ReadtabPage.Text = "чтение данных";
            this.ReadtabPage.UseVisualStyleBackColor = true;
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(812, 40);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(248, 27);
            this.readTextBox.TabIndex = 3;
            // 
            // readComboBox
            // 
            this.readComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readComboBox.FormattingEnabled = true;
            this.readComboBox.Items.AddRange(new object[] {
            "InfoV1",
            "User1",
            "UserInfoV1",
            "UserInfov2"});
            this.readComboBox.Location = new System.Drawing.Point(811, 6);
            this.readComboBox.Name = "readComboBox";
            this.readComboBox.Size = new System.Drawing.Size(249, 28);
            this.readComboBox.TabIndex = 2;
            this.readComboBox.SelectedIndexChanged += new System.EventHandler(this.readComboBox_SelectedIndexChanged);
            // 
            // ReaddataGridView
            // 
            this.ReaddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaddataGridView.Location = new System.Drawing.Point(6, 6);
            this.ReaddataGridView.Name = "ReaddataGridView";
            this.ReaddataGridView.RowHeadersWidth = 24;
            this.ReaddataGridView.RowTemplate.Height = 29;
            this.ReaddataGridView.Size = new System.Drawing.Size(800, 469);
            this.ReaddataGridView.TabIndex = 1;
            // 
            // AddtabPage
            // 
            this.AddtabPage.Controls.Add(this.generateAddButton);
            this.AddtabPage.Controls.Add(this.Addbutton);
            this.AddtabPage.Controls.Add(this.addComboBox);
            this.AddtabPage.Controls.Add(this.addTextBox);
            this.AddtabPage.Controls.Add(this.AdddataGridView);
            this.AddtabPage.Location = new System.Drawing.Point(4, 29);
            this.AddtabPage.Name = "AddtabPage";
            this.AddtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddtabPage.Size = new System.Drawing.Size(1066, 481);
            this.AddtabPage.TabIndex = 1;
            this.AddtabPage.Text = "добавление данных";
            this.AddtabPage.UseVisualStyleBackColor = true;
            // 
            // generateAddButton
            // 
            this.generateAddButton.Location = new System.Drawing.Point(812, 73);
            this.generateAddButton.Name = "generateAddButton";
            this.generateAddButton.Size = new System.Drawing.Size(248, 29);
            this.generateAddButton.TabIndex = 4;
            this.generateAddButton.Text = "Сгенерировать выборку";
            this.generateAddButton.UseVisualStyleBackColor = true;
            this.generateAddButton.Click += new System.EventHandler(this.generateAddButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(812, 108);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(248, 28);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.Text = "добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // addComboBox
            // 
            this.addComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addComboBox.FormattingEnabled = true;
            this.addComboBox.Items.AddRange(new object[] {
            "InfoV1",
            "User1",
            "UserInfoV1",
            "UserInfov2"});
            this.addComboBox.Location = new System.Drawing.Point(812, 6);
            this.addComboBox.Name = "addComboBox";
            this.addComboBox.Size = new System.Drawing.Size(248, 28);
            this.addComboBox.TabIndex = 2;
            this.addComboBox.SelectedIndexChanged += new System.EventHandler(this.AddcomboBox_SelectedIndexChanged);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(812, 40);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(248, 27);
            this.addTextBox.TabIndex = 1;
            this.addTextBox.Text = "10";
            // 
            // AdddataGridView
            // 
            this.AdddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdddataGridView.Location = new System.Drawing.Point(6, 6);
            this.AdddataGridView.Name = "AdddataGridView";
            this.AdddataGridView.RowHeadersWidth = 24;
            this.AdddataGridView.RowTemplate.Height = 29;
            this.AdddataGridView.Size = new System.Drawing.Size(800, 469);
            this.AdddataGridView.TabIndex = 0;
            // 
            // ChangestabPage
            // 
            this.ChangestabPage.Controls.Add(this.GenerateUpdatebutton);
            this.ChangestabPage.Controls.Add(this.UpdatecomboBox);
            this.ChangestabPage.Controls.Add(this.updateTextBox);
            this.ChangestabPage.Controls.Add(this.Updatebutton);
            this.ChangestabPage.Controls.Add(this.NewdataGridView);
            this.ChangestabPage.Controls.Add(this.OlddataGridView);
            this.ChangestabPage.Location = new System.Drawing.Point(4, 29);
            this.ChangestabPage.Name = "ChangestabPage";
            this.ChangestabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChangestabPage.Size = new System.Drawing.Size(1066, 481);
            this.ChangestabPage.TabIndex = 2;
            this.ChangestabPage.Text = "изменение";
            this.ChangestabPage.UseVisualStyleBackColor = true;
            // 
            // GenerateUpdatebutton
            // 
            this.GenerateUpdatebutton.Location = new System.Drawing.Point(442, 73);
            this.GenerateUpdatebutton.Name = "GenerateUpdatebutton";
            this.GenerateUpdatebutton.Size = new System.Drawing.Size(186, 53);
            this.GenerateUpdatebutton.TabIndex = 7;
            this.GenerateUpdatebutton.Text = "Сгенерировать\r\n  выборку";
            this.GenerateUpdatebutton.UseVisualStyleBackColor = true;
            this.GenerateUpdatebutton.Click += new System.EventHandler(this.GenerateUpdatebutton_Click);
            // 
            // UpdatecomboBox
            // 
            this.UpdatecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdatecomboBox.FormattingEnabled = true;
            this.UpdatecomboBox.Items.AddRange(new object[] {
            "InfoV1",
            "User1",
            "UserInfoV1",
            "UserInfov2"});
            this.UpdatecomboBox.Location = new System.Drawing.Point(442, 6);
            this.UpdatecomboBox.Name = "UpdatecomboBox";
            this.UpdatecomboBox.Size = new System.Drawing.Size(186, 28);
            this.UpdatecomboBox.TabIndex = 4;
            this.UpdatecomboBox.SelectedIndexChanged += new System.EventHandler(this.UpdatecomboBox_SelectedIndexChanged);
            // 
            // updateTextBox
            // 
            this.updateTextBox.Location = new System.Drawing.Point(442, 40);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(186, 27);
            this.updateTextBox.TabIndex = 3;
            this.updateTextBox.Text = "10";
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(442, 132);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(186, 31);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "Обновить";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // NewdataGridView
            // 
            this.NewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewdataGridView.Location = new System.Drawing.Point(634, 6);
            this.NewdataGridView.Name = "NewdataGridView";
            this.NewdataGridView.RowHeadersWidth = 12;
            this.NewdataGridView.RowTemplate.Height = 29;
            this.NewdataGridView.Size = new System.Drawing.Size(426, 469);
            this.NewdataGridView.TabIndex = 1;
            // 
            // OlddataGridView
            // 
            this.OlddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OlddataGridView.Location = new System.Drawing.Point(6, 6);
            this.OlddataGridView.Name = "OlddataGridView";
            this.OlddataGridView.RowHeadersWidth = 12;
            this.OlddataGridView.RowTemplate.Height = 29;
            this.OlddataGridView.Size = new System.Drawing.Size(430, 469);
            this.OlddataGridView.TabIndex = 0;
            // 
            // DeletetabPage
            // 
            this.DeletetabPage.Controls.Add(this.deleteAll);
            this.DeletetabPage.Controls.Add(this.GenerateDeleteButton);
            this.DeletetabPage.Controls.Add(this.DeletecomboBox);
            this.DeletetabPage.Controls.Add(this.deleteTextBox);
            this.DeletetabPage.Controls.Add(this.Deletebutton);
            this.DeletetabPage.Controls.Add(this.DeletedataGridView);
            this.DeletetabPage.Location = new System.Drawing.Point(4, 29);
            this.DeletetabPage.Name = "DeletetabPage";
            this.DeletetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DeletetabPage.Size = new System.Drawing.Size(1066, 481);
            this.DeletetabPage.TabIndex = 3;
            this.DeletetabPage.Text = "удаление";
            this.DeletetabPage.UseVisualStyleBackColor = true;
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(812, 144);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(248, 29);
            this.deleteAll.TabIndex = 5;
            this.deleteAll.Text = "Очистить таблицу";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // GenerateDeleteButton
            // 
            this.GenerateDeleteButton.Location = new System.Drawing.Point(812, 73);
            this.GenerateDeleteButton.Name = "GenerateDeleteButton";
            this.GenerateDeleteButton.Size = new System.Drawing.Size(248, 29);
            this.GenerateDeleteButton.TabIndex = 4;
            this.GenerateDeleteButton.Text = "Сгенерировать выборку";
            this.GenerateDeleteButton.UseVisualStyleBackColor = true;
            this.GenerateDeleteButton.Click += new System.EventHandler(this.GenerateDeleteButton_Click);
            // 
            // DeletecomboBox
            // 
            this.DeletecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletecomboBox.FormattingEnabled = true;
            this.DeletecomboBox.Items.AddRange(new object[] {
            "InfoV1",
            "User1",
            "UserInfoV1",
            "UserInfov2"});
            this.DeletecomboBox.Location = new System.Drawing.Point(812, 6);
            this.DeletecomboBox.Name = "DeletecomboBox";
            this.DeletecomboBox.Size = new System.Drawing.Size(248, 28);
            this.DeletecomboBox.TabIndex = 3;
            this.DeletecomboBox.SelectedIndexChanged += new System.EventHandler(this.DeletecomboBox_SelectedIndexChanged);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(812, 40);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(248, 27);
            this.deleteTextBox.TabIndex = 2;
            this.deleteTextBox.Text = "10";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(812, 108);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(248, 30);
            this.Deletebutton.TabIndex = 1;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // DeletedataGridView
            // 
            this.DeletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeletedataGridView.Location = new System.Drawing.Point(6, 6);
            this.DeletedataGridView.Name = "DeletedataGridView";
            this.DeletedataGridView.RowHeadersWidth = 24;
            this.DeletedataGridView.RowTemplate.Height = 29;
            this.DeletedataGridView.Size = new System.Drawing.Size(800, 469);
            this.DeletedataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 534);
            this.Controls.Add(this.MaintabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1116, 585);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1116, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MaintabControl.ResumeLayout(false);
            this.ReadtabPage.ResumeLayout(false);
            this.ReadtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaddataGridView)).EndInit();
            this.AddtabPage.ResumeLayout(false);
            this.AddtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdddataGridView)).EndInit();
            this.ChangestabPage.ResumeLayout(false);
            this.ChangestabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlddataGridView)).EndInit();
            this.DeletetabPage.ResumeLayout(false);
            this.DeletetabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Readbutton;
        private TabControl MaintabControl;
        private TabPage ReadtabPage;
        private DataGridView ReaddataGridView;
        private TabPage AddtabPage;
        private TextBox readTextBox;
        private ComboBox readComboBox;
        private Button Addbutton;
        private ComboBox addComboBox;
        private TextBox addTextBox;
        private DataGridView AdddataGridView;
        private TabPage DeletetabPage;
        private ComboBox DeletecomboBox;
        private TextBox deleteTextBox;
        private Button Deletebutton;
        private DataGridView DeletedataGridView;
        private TabPage ChangestabPage;
        private Button GenerateUpdatebutton;
        private ComboBox UpdatecomboBox;
        private TextBox updateTextBox;
        private Button Updatebutton;
        private DataGridView NewdataGridView;
        private DataGridView OlddataGridView;
        private Button GenerateDeleteButton;
        private Button deleteAll;
        private Button generateAddButton;
    }
}