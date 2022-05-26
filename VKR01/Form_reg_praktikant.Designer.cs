
namespace VKR01
{
    partial class Form_reg_praktikant
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
            this.tbLogPrak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassPrak = new System.Windows.Forms.TextBox();
            this.tbNamePrak = new System.Windows.Forms.TextBox();
            this.tbSurnamePrak = new System.Windows.Forms.TextBox();
            this.tbPatPrak = new System.Windows.Forms.TextBox();
            this.tbGroupPrak = new System.Windows.Forms.TextBox();
            this.maskedTBPhonePrak = new System.Windows.Forms.MaskedTextBox();
            this.tbNazvSpecial = new System.Windows.Forms.TextBox();
            this.cbRukovodPrak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butReg_prak = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.cbSexPrak = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTBbeginPrak = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTBendPrak = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogPrak
            // 
            this.tbLogPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogPrak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLogPrak.Location = new System.Drawing.Point(52, 162);
            this.tbLogPrak.Name = "tbLogPrak";
            this.tbLogPrak.Size = new System.Drawing.Size(180, 47);
            this.tbLogPrak.TabIndex = 0;
            this.tbLogPrak.TextChanged += new System.EventHandler(this.tbLogPrak_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация практиканта";
            // 
            // tbPassPrak
            // 
            this.tbPassPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassPrak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassPrak.Location = new System.Drawing.Point(52, 256);
            this.tbPassPrak.Name = "tbPassPrak";
            this.tbPassPrak.Size = new System.Drawing.Size(180, 47);
            this.tbPassPrak.TabIndex = 2;
            // 
            // tbNamePrak
            // 
            this.tbNamePrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamePrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNamePrak.Location = new System.Drawing.Point(331, 162);
            this.tbNamePrak.Name = "tbNamePrak";
            this.tbNamePrak.Size = new System.Drawing.Size(180, 34);
            this.tbNamePrak.TabIndex = 3;
            // 
            // tbSurnamePrak
            // 
            this.tbSurnamePrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurnamePrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSurnamePrak.Location = new System.Drawing.Point(331, 266);
            this.tbSurnamePrak.Name = "tbSurnamePrak";
            this.tbSurnamePrak.Size = new System.Drawing.Size(180, 34);
            this.tbSurnamePrak.TabIndex = 4;
            // 
            // tbPatPrak
            // 
            this.tbPatPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPatPrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPatPrak.Location = new System.Drawing.Point(331, 361);
            this.tbPatPrak.Name = "tbPatPrak";
            this.tbPatPrak.Size = new System.Drawing.Size(180, 34);
            this.tbPatPrak.TabIndex = 5;
            // 
            // tbGroupPrak
            // 
            this.tbGroupPrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGroupPrak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGroupPrak.Location = new System.Drawing.Point(892, 302);
            this.tbGroupPrak.Name = "tbGroupPrak";
            this.tbGroupPrak.Size = new System.Drawing.Size(180, 34);
            this.tbGroupPrak.TabIndex = 9;
            // 
            // maskedTBPhonePrak
            // 
            this.maskedTBPhonePrak.Location = new System.Drawing.Point(609, 162);
            this.maskedTBPhonePrak.Mask = "+9(999)999-99-99";
            this.maskedTBPhonePrak.Name = "maskedTBPhonePrak";
            this.maskedTBPhonePrak.Size = new System.Drawing.Size(125, 27);
            this.maskedTBPhonePrak.TabIndex = 12;
            // 
            // tbNazvSpecial
            // 
            this.tbNazvSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNazvSpecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNazvSpecial.Location = new System.Drawing.Point(821, 156);
            this.tbNazvSpecial.Multiline = true;
            this.tbNazvSpecial.Name = "tbNazvSpecial";
            this.tbNazvSpecial.Size = new System.Drawing.Size(313, 107);
            this.tbNazvSpecial.TabIndex = 14;
            // 
            // cbRukovodPrak
            // 
            this.cbRukovodPrak.FormattingEnabled = true;
            this.cbRukovodPrak.Location = new System.Drawing.Point(584, 252);
            this.cbRukovodPrak.Name = "cbRukovodPrak";
            this.cbRukovodPrak.Size = new System.Drawing.Size(198, 28);
            this.cbRukovodPrak.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Придумайте логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Придумайте пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(948, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Группа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(906, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Специальность";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Руководитель практики";
            // 
            // butReg_prak
            // 
            this.butReg_prak.Location = new System.Drawing.Point(52, 365);
            this.butReg_prak.Name = "butReg_prak";
            this.butReg_prak.Size = new System.Drawing.Size(180, 42);
            this.butReg_prak.TabIndex = 27;
            this.butReg_prak.Text = "Зарегистрировать";
            this.butReg_prak.UseVisualStyleBackColor = true;
            this.butReg_prak.Click += new System.EventHandler(this.butReg_prak_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(52, 432);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(180, 42);
            this.butBack.TabIndex = 28;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // cbSexPrak
            // 
            this.cbSexPrak.FormattingEnabled = true;
            this.cbSexPrak.Location = new System.Drawing.Point(584, 330);
            this.cbSexPrak.Name = "cbSexPrak";
            this.cbSexPrak.Size = new System.Drawing.Size(198, 28);
            this.cbSexPrak.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(637, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Пол";
            // 
            // maskedTBbeginPrak
            // 
            this.maskedTBbeginPrak.Location = new System.Drawing.Point(584, 396);
            this.maskedTBbeginPrak.Mask = "00/00/0000";
            this.maskedTBbeginPrak.Name = "maskedTBbeginPrak";
            this.maskedTBbeginPrak.Size = new System.Drawing.Size(198, 27);
            this.maskedTBbeginPrak.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(600, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Начало практики";
            // 
            // maskedTBendPrak
            // 
            this.maskedTBendPrak.Location = new System.Drawing.Point(584, 452);
            this.maskedTBendPrak.Mask = "00/00/0000";
            this.maskedTBendPrak.Name = "maskedTBendPrak";
            this.maskedTBendPrak.Size = new System.Drawing.Size(198, 27);
            this.maskedTBendPrak.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(600, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Конец практики";
            // 
            // Form_reg_praktikant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1162, 505);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maskedTBendPrak);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maskedTBbeginPrak);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbSexPrak);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butReg_prak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRukovodPrak);
            this.Controls.Add(this.tbNazvSpecial);
            this.Controls.Add(this.maskedTBPhonePrak);
            this.Controls.Add(this.tbGroupPrak);
            this.Controls.Add(this.tbPatPrak);
            this.Controls.Add(this.tbSurnamePrak);
            this.Controls.Add(this.tbNamePrak);
            this.Controls.Add(this.tbPassPrak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogPrak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_reg_praktikant";
            this.Text = "ДОБАВЛЕНИЕ ПРАКТИКАНТА";
            this.Load += new System.EventHandler(this.Form_reg_praktikant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogPrak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassPrak;
        private System.Windows.Forms.TextBox tbNamePrak;
        private System.Windows.Forms.TextBox tbSurnamePrak;
        private System.Windows.Forms.TextBox tbPatPrak;
        private System.Windows.Forms.TextBox tbGroupPrak;
        private System.Windows.Forms.MaskedTextBox maskedTBPhonePrak;
        private System.Windows.Forms.TextBox tbNazvSpecial;
        private System.Windows.Forms.ComboBox cbRukovodPrak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butReg_prak;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.ComboBox cbSexPrak;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTBbeginPrak;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTBendPrak;
        private System.Windows.Forms.Label label15;
    }
}