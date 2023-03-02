namespace DataHub_Tester
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.generationInstances = new System.Windows.Forms.TabPage();
            this.generateButton = new System.Windows.Forms.Button();
            this.quantityInstanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEntityes = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sendAPIPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.generationInstances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sendAPIPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.generationInstances);
            this.mainTabControl.Controls.Add(this.sendAPIPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1061, 491);
            this.mainTabControl.TabIndex = 0;
            // 
            // generationInstances
            // 
            this.generationInstances.Controls.Add(this.generateButton);
            this.generationInstances.Controls.Add(this.quantityInstanceTextBox);
            this.generationInstances.Controls.Add(this.label2);
            this.generationInstances.Controls.Add(this.label1);
            this.generationInstances.Controls.Add(this.comboBoxEntityes);
            this.generationInstances.Controls.Add(this.dataGridView1);
            this.generationInstances.Location = new System.Drawing.Point(4, 25);
            this.generationInstances.Name = "generationInstances";
            this.generationInstances.Padding = new System.Windows.Forms.Padding(3);
            this.generationInstances.Size = new System.Drawing.Size(1053, 462);
            this.generationInstances.TabIndex = 0;
            this.generationInstances.Text = "generation_Instances";
            this.generationInstances.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(820, 161);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(227, 37);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Сгенерировать нахуй";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // quantityInstanceTextBox
            // 
            this.quantityInstanceTextBox.Location = new System.Drawing.Point(820, 121);
            this.quantityInstanceTextBox.Name = "quantityInstanceTextBox";
            this.quantityInstanceTextBox.Size = new System.Drawing.Size(227, 22);
            this.quantityInstanceTextBox.TabIndex = 3;
            this.quantityInstanceTextBox.Text = "100";
            this.quantityInstanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество экземпляров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите таблицу";
            // 
            // comboBoxEntityes
            // 
            this.comboBoxEntityes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntityes.FormattingEnabled = true;
            this.comboBoxEntityes.Items.AddRange(new object[] {
            "Info_v1",
            "User_1",
            "UserInfo_v1",
            "UserInfo_v2"});
            this.comboBoxEntityes.Location = new System.Drawing.Point(820, 38);
            this.comboBoxEntityes.Name = "comboBoxEntityes";
            this.comboBoxEntityes.Size = new System.Drawing.Size(227, 24);
            this.comboBoxEntityes.TabIndex = 1;
            this.comboBoxEntityes.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntityes_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // sendAPIPage
            // 
            this.sendAPIPage.Controls.Add(this.button2);
            this.sendAPIPage.Controls.Add(this.button1);
            this.sendAPIPage.Location = new System.Drawing.Point(4, 25);
            this.sendAPIPage.Name = "sendAPIPage";
            this.sendAPIPage.Padding = new System.Windows.Forms.Padding(3);
            this.sendAPIPage.Size = new System.Drawing.Size(1053, 462);
            this.sendAPIPage.TabIndex = 1;
            this.sendAPIPage.Text = "send_to_API";
            this.sendAPIPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(549, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(501, 448);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear Table";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(535, 448);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send TO API";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 503);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.generationInstances.ResumeLayout(false);
            this.generationInstances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sendAPIPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage generationInstances;
        private System.Windows.Forms.TabPage sendAPIPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEntityes;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox quantityInstanceTextBox;
        private System.Windows.Forms.Label label2;
    }
}

