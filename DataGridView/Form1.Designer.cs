namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generateUser = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.TabControlEntityes = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.labelProduct = new System.Windows.Forms.Label();
            this.generateProduct = new System.Windows.Forms.Button();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.generatePurchase = new System.Windows.Forms.Button();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.textBoxPurchase = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageScialNetwork = new System.Windows.Forms.TabPage();
            this.labelSocialNetwork = new System.Windows.Forms.Label();
            this.textBoxSocialNetwork = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.generateSocialNetwork = new System.Windows.Forms.Button();
            this.tabPagePhoneNumber = new System.Windows.Forms.TabPage();
            this.generatePhoneNumber = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControlEntityes.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageScialNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPagePhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(940, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // generateUser
            // 
            this.generateUser.AutoSize = true;
            this.generateUser.Location = new System.Drawing.Point(949, 76);
            this.generateUser.Name = "generateUser";
            this.generateUser.Size = new System.Drawing.Size(118, 26);
            this.generateUser.TabIndex = 1;
            this.generateUser.Text = "Сгенерировать";
            this.generateUser.UseVisualStyleBackColor = true;
            this.generateUser.Click += new System.EventHandler(this.generateUser_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(949, 48);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(118, 22);
            this.textBoxUser.TabIndex = 2;
            // 
            // TabControlEntityes
            // 
            this.TabControlEntityes.Controls.Add(this.tabPageUser);
            this.TabControlEntityes.Controls.Add(this.tabPageProduct);
            this.TabControlEntityes.Controls.Add(this.tabPagePurchase);
            this.TabControlEntityes.Controls.Add(this.tabPageScialNetwork);
            this.TabControlEntityes.Controls.Add(this.tabPagePhoneNumber);
            this.TabControlEntityes.Location = new System.Drawing.Point(12, 12);
            this.TabControlEntityes.Name = "TabControlEntityes";
            this.TabControlEntityes.SelectedIndex = 0;
            this.TabControlEntityes.Size = new System.Drawing.Size(1081, 551);
            this.TabControlEntityes.TabIndex = 4;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.labelUser);
            this.tabPageUser.Controls.Add(this.dataGridView1);
            this.tabPageUser.Controls.Add(this.generateUser);
            this.tabPageUser.Controls.Add(this.textBoxUser);
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(1073, 522);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(949, 6);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(124, 32);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "        Введите\r\nколичество строк";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.labelProduct);
            this.tabPageProduct.Controls.Add(this.generateProduct);
            this.tabPageProduct.Controls.Add(this.textBoxProduct);
            this.tabPageProduct.Controls.Add(this.dataGridView2);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(1073, 522);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(949, 3);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(125, 32);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "          Введите\r\nКоличество строк";
            // 
            // generateProduct
            // 
            this.generateProduct.AutoSize = true;
            this.generateProduct.Location = new System.Drawing.Point(952, 81);
            this.generateProduct.Name = "generateProduct";
            this.generateProduct.Size = new System.Drawing.Size(118, 32);
            this.generateProduct.TabIndex = 2;
            this.generateProduct.Text = "Сгенерировать";
            this.generateProduct.UseVisualStyleBackColor = true;
            this.generateProduct.Click += new System.EventHandler(this.GenerateProduct_Click);
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(952, 53);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(115, 22);
            this.textBoxProduct.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(940, 500);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.generatePurchase);
            this.tabPagePurchase.Controls.Add(this.labelPurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxPurchase);
            this.tabPagePurchase.Controls.Add(this.dataGridView3);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1073, 522);
            this.tabPagePurchase.TabIndex = 2;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // generatePurchase
            // 
            this.generatePurchase.AutoSize = true;
            this.generatePurchase.Location = new System.Drawing.Point(952, 75);
            this.generatePurchase.Name = "generatePurchase";
            this.generatePurchase.Size = new System.Drawing.Size(118, 29);
            this.generatePurchase.TabIndex = 3;
            this.generatePurchase.Text = "Сгенерировать";
            this.generatePurchase.UseVisualStyleBackColor = true;
            this.generatePurchase.Click += new System.EventHandler(this.GeneratePurchase_Click);
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Location = new System.Drawing.Point(945, 3);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(125, 32);
            this.labelPurchase.TabIndex = 2;
            this.labelPurchase.Text = "         Введите\r\nКоличество строк";
            // 
            // textBoxPurchase
            // 
            this.textBoxPurchase.Location = new System.Drawing.Point(952, 47);
            this.textBoxPurchase.Name = "textBoxPurchase";
            this.textBoxPurchase.Size = new System.Drawing.Size(118, 22);
            this.textBoxPurchase.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(940, 500);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPageScialNetwork
            // 
            this.tabPageScialNetwork.Controls.Add(this.labelSocialNetwork);
            this.tabPageScialNetwork.Controls.Add(this.textBoxSocialNetwork);
            this.tabPageScialNetwork.Controls.Add(this.dataGridView4);
            this.tabPageScialNetwork.Controls.Add(this.generateSocialNetwork);
            this.tabPageScialNetwork.Location = new System.Drawing.Point(4, 25);
            this.tabPageScialNetwork.Name = "tabPageScialNetwork";
            this.tabPageScialNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScialNetwork.Size = new System.Drawing.Size(1073, 522);
            this.tabPageScialNetwork.TabIndex = 3;
            this.tabPageScialNetwork.Text = "SocialNetwork";
            this.tabPageScialNetwork.UseVisualStyleBackColor = true;
            // 
            // labelSocialNetwork
            // 
            this.labelSocialNetwork.AutoSize = true;
            this.labelSocialNetwork.Location = new System.Drawing.Point(953, 6);
            this.labelSocialNetwork.Name = "labelSocialNetwork";
            this.labelSocialNetwork.Size = new System.Drawing.Size(124, 32);
            this.labelSocialNetwork.TabIndex = 3;
            this.labelSocialNetwork.Text = "            Введите \r\nколичество строк";
            // 
            // textBoxSocialNetwork
            // 
            this.textBoxSocialNetwork.Location = new System.Drawing.Point(967, 46);
            this.textBoxSocialNetwork.Name = "textBoxSocialNetwork";
            this.textBoxSocialNetwork.Size = new System.Drawing.Size(100, 22);
            this.textBoxSocialNetwork.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(952, 510);
            this.dataGridView4.TabIndex = 1;
            // 
            // generateSocialNetwork
            // 
            this.generateSocialNetwork.Location = new System.Drawing.Point(956, 74);
            this.generateSocialNetwork.Name = "generateSocialNetwork";
            this.generateSocialNetwork.Size = new System.Drawing.Size(117, 27);
            this.generateSocialNetwork.TabIndex = 0;
            this.generateSocialNetwork.Text = "Сгенерировать";
            this.generateSocialNetwork.UseVisualStyleBackColor = true;
            this.generateSocialNetwork.Click += new System.EventHandler(this.GenerateSocialNetwork_Click);
            // 
            // tabPagePhoneNumber
            // 
            this.tabPagePhoneNumber.Controls.Add(this.generatePhoneNumber);
            this.tabPagePhoneNumber.Controls.Add(this.labelPhoneNumber);
            this.tabPagePhoneNumber.Controls.Add(this.textBoxPhoneNumber);
            this.tabPagePhoneNumber.Controls.Add(this.dataGridView5);
            this.tabPagePhoneNumber.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhoneNumber.Name = "tabPagePhoneNumber";
            this.tabPagePhoneNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhoneNumber.Size = new System.Drawing.Size(1073, 522);
            this.tabPagePhoneNumber.TabIndex = 4;
            this.tabPagePhoneNumber.Text = "PhoneNumber";
            this.tabPagePhoneNumber.UseVisualStyleBackColor = true;
            // 
            // generatePhoneNumber
            // 
            this.generatePhoneNumber.AutoSize = true;
            this.generatePhoneNumber.Location = new System.Drawing.Point(959, 74);
            this.generatePhoneNumber.Name = "generatePhoneNumber";
            this.generatePhoneNumber.Size = new System.Drawing.Size(118, 26);
            this.generatePhoneNumber.TabIndex = 4;
            this.generatePhoneNumber.Text = "Сгенерировать";
            this.generatePhoneNumber.UseVisualStyleBackColor = true;
            this.generatePhoneNumber.Click += new System.EventHandler(this.GeneratePhoneNumber_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(953, 3);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(124, 32);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "          Введите\r\nколичество строк";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(970, 46);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhoneNumber.TabIndex = 2;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(955, 510);
            this.dataGridView5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 575);
            this.Controls.Add(this.TabControlEntityes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControlEntityes.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageScialNetwork.ResumeLayout(false);
            this.tabPageScialNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPagePhoneNumber.ResumeLayout(false);
            this.tabPagePhoneNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generateUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TabControl TabControlEntityes;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button generateProduct;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabPageScialNetwork;
        private System.Windows.Forms.Button generatePurchase;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.TextBox textBoxPurchase;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelSocialNetwork;
        private System.Windows.Forms.TextBox textBoxSocialNetwork;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPagePhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button generatePhoneNumber;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button generateSocialNetwork;
    }
}

