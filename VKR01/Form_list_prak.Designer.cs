
namespace VKR01
{
    partial class Form_list_prak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butAddPrak = new System.Windows.Forms.Button();
            this.butDelPrak = new System.Windows.Forms.Button();
            this.butChangePrak = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPatPrak = new System.Windows.Forms.TextBox();
            this.tbSurnamePrak = new System.Windows.Forms.TextBox();
            this.tbNamePrak = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNazvSpecial = new System.Windows.Forms.TextBox();
            this.maskedTBPhonePrak = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGroupPrak = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTBendPrak = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTBbeginPrak = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.butFilter = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1429, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // butAddPrak
            // 
            this.butAddPrak.Location = new System.Drawing.Point(62, 417);
            this.butAddPrak.Name = "butAddPrak";
            this.butAddPrak.Size = new System.Drawing.Size(220, 29);
            this.butAddPrak.TabIndex = 1;
            this.butAddPrak.Text = "Добавить практиканта";
            this.butAddPrak.UseVisualStyleBackColor = true;
            this.butAddPrak.Click += new System.EventHandler(this.butAddPrak_Click);
            // 
            // butDelPrak
            // 
            this.butDelPrak.Location = new System.Drawing.Point(62, 469);
            this.butDelPrak.Name = "butDelPrak";
            this.butDelPrak.Size = new System.Drawing.Size(220, 29);
            this.butDelPrak.TabIndex = 2;
            this.butDelPrak.Text = "Удалить практиканта";
            this.butDelPrak.UseVisualStyleBackColor = true;
            this.butDelPrak.Click += new System.EventHandler(this.butDelPrak_Click);
            // 
            // butChangePrak
            // 
            this.butChangePrak.Location = new System.Drawing.Point(62, 523);
            this.butChangePrak.Name = "butChangePrak";
            this.butChangePrak.Size = new System.Drawing.Size(220, 29);
            this.butChangePrak.TabIndex = 3;
            this.butChangePrak.Text = "Изменить";
            this.butChangePrak.UseVisualStyleBackColor = true;
            this.butChangePrak.Click += new System.EventHandler(this.butChangePrak_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Имя";
            // 
            // tbPatPrak
            // 
            this.tbPatPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPatPrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPatPrak.Location = new System.Drawing.Point(335, 610);
            this.tbPatPrak.Name = "tbPatPrak";
            this.tbPatPrak.Size = new System.Drawing.Size(180, 34);
            this.tbPatPrak.TabIndex = 23;
            // 
            // tbSurnamePrak
            // 
            this.tbSurnamePrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurnamePrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSurnamePrak.Location = new System.Drawing.Point(335, 515);
            this.tbSurnamePrak.Name = "tbSurnamePrak";
            this.tbSurnamePrak.Size = new System.Drawing.Size(180, 34);
            this.tbSurnamePrak.TabIndex = 22;
            // 
            // tbNamePrak
            // 
            this.tbNamePrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamePrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNamePrak.Location = new System.Drawing.Point(335, 411);
            this.tbNamePrak.Name = "tbNamePrak";
            this.tbNamePrak.Size = new System.Drawing.Size(180, 34);
            this.tbNamePrak.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(954, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Специальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Номер телефона";
            // 
            // tbNazvSpecial
            // 
            this.tbNazvSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNazvSpecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNazvSpecial.Location = new System.Drawing.Point(809, 411);
            this.tbNazvSpecial.Multiline = true;
            this.tbNazvSpecial.Name = "tbNazvSpecial";
            this.tbNazvSpecial.Size = new System.Drawing.Size(456, 63);
            this.tbNazvSpecial.TabIndex = 28;
            // 
            // maskedTBPhonePrak
            // 
            this.maskedTBPhonePrak.Location = new System.Drawing.Point(561, 417);
            this.maskedTBPhonePrak.Mask = "+9(999)999-99-99";
            this.maskedTBPhonePrak.Name = "maskedTBPhonePrak";
            this.maskedTBPhonePrak.Size = new System.Drawing.Size(200, 27);
            this.maskedTBPhonePrak.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Группа";
            // 
            // tbGroupPrak
            // 
            this.tbGroupPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGroupPrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGroupPrak.Location = new System.Drawing.Point(561, 500);
            this.tbGroupPrak.Name = "tbGroupPrak";
            this.tbGroupPrak.Size = new System.Drawing.Size(200, 34);
            this.tbGroupPrak.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 611);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Конец практики";
            // 
            // maskedTBendPrak
            // 
            this.maskedTBendPrak.Location = new System.Drawing.Point(561, 634);
            this.maskedTBendPrak.Mask = "00/00/0000";
            this.maskedTBendPrak.Name = "maskedTBendPrak";
            this.maskedTBendPrak.Size = new System.Drawing.Size(200, 27);
            this.maskedTBendPrak.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(579, 555);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Начало практики";
            // 
            // maskedTBbeginPrak
            // 
            this.maskedTBbeginPrak.Location = new System.Drawing.Point(561, 578);
            this.maskedTBbeginPrak.Mask = "00/00/0000";
            this.maskedTBbeginPrak.Name = "maskedTBbeginPrak";
            this.maskedTBbeginPrak.Size = new System.Drawing.Size(200, 27);
            this.maskedTBbeginPrak.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 82);
            this.button1.TabIndex = 39;
            this.button1.Text = "Изменить руководителя практики\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(811, 537);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(195, 27);
            this.butSearch.TabIndex = 40;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.Location = new System.Drawing.Point(811, 497);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(195, 34);
            this.tbSearch.TabIndex = 41;
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilter.Location = new System.Drawing.Point(1059, 497);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(206, 34);
            this.tbFilter.TabIndex = 43;
            // 
            // butFilter
            // 
            this.butFilter.Location = new System.Drawing.Point(1059, 537);
            this.butFilter.Name = "butFilter";
            this.butFilter.Size = new System.Drawing.Size(206, 30);
            this.butFilter.TabIndex = 42;
            this.butFilter.Text = "Фильтрация (Фамилия)";
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(1304, 610);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(113, 55);
            this.butBack.TabIndex = 44;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 30);
            this.button2.TabIndex = 45;
            this.button2.Text = "ЭКСПОРТ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_list_prak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 671);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.butFilter);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maskedTBendPrak);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maskedTBbeginPrak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGroupPrak);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNazvSpecial);
            this.Controls.Add(this.maskedTBPhonePrak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPatPrak);
            this.Controls.Add(this.tbSurnamePrak);
            this.Controls.Add(this.tbNamePrak);
            this.Controls.Add(this.butChangePrak);
            this.Controls.Add(this.butDelPrak);
            this.Controls.Add(this.butAddPrak);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_list_prak";
            this.Text = "СПИСОК ПРАКТИКАНТОВ";
            this.Load += new System.EventHandler(this.Form_list_prak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAddPrak;
        private System.Windows.Forms.Button butDelPrak;
        private System.Windows.Forms.Button butChangePrak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatPrak;
        private System.Windows.Forms.TextBox tbSurnamePrak;
        private System.Windows.Forms.TextBox tbNamePrak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNazvSpecial;
        private System.Windows.Forms.MaskedTextBox maskedTBPhonePrak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGroupPrak;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTBendPrak;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTBbeginPrak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button button2;
    }
}