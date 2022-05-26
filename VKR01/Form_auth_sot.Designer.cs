
namespace VKR01
{
    partial class Form_auth_sot
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogSot = new System.Windows.Forms.TextBox();
            this.tbPassSot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butLogSot = new System.Windows.Forms.Button();
            this.butBack1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторизация";
            // 
            // tbLogSot
            // 
            this.tbLogSot.Location = new System.Drawing.Point(143, 172);
            this.tbLogSot.Name = "tbLogSot";
            this.tbLogSot.PlaceholderText = "Логин";
            this.tbLogSot.Size = new System.Drawing.Size(195, 27);
            this.tbLogSot.TabIndex = 3;
            // 
            // tbPassSot
            // 
            this.tbPassSot.Location = new System.Drawing.Point(143, 240);
            this.tbPassSot.Name = "tbPassSot";
            this.tbPassSot.PasswordChar = '*';
            this.tbPassSot.PlaceholderText = "Пароль";
            this.tbPassSot.Size = new System.Drawing.Size(195, 27);
            this.tbPassSot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(198, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // butLogSot
            // 
            this.butLogSot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogSot.Location = new System.Drawing.Point(178, 293);
            this.butLogSot.Name = "butLogSot";
            this.butLogSot.Size = new System.Drawing.Size(125, 34);
            this.butLogSot.TabIndex = 7;
            this.butLogSot.Text = "ВХОД";
            this.butLogSot.UseVisualStyleBackColor = true;
            this.butLogSot.Click += new System.EventHandler(this.butLogSot_Click);
            // 
            // butBack1
            // 
            this.butBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack1.Location = new System.Drawing.Point(415, 409);
            this.butBack1.Name = "butBack1";
            this.butBack1.Size = new System.Drawing.Size(75, 29);
            this.butBack1.TabIndex = 8;
            this.butBack1.Text = "Назад";
            this.butBack1.UseVisualStyleBackColor = true;
            this.butBack1.Click += new System.EventHandler(this.butBack1_Click);
            // 
            // Form_auth_sot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.butBack1);
            this.Controls.Add(this.butLogSot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassSot);
            this.Controls.Add(this.tbLogSot);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_auth_sot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОКНО АВТОРИЗАЦИИ СОТРУДНИКОВ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogSot;
        private System.Windows.Forms.TextBox tbPassSot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butLogSot;
        private System.Windows.Forms.Button butBack1;
        private System.Windows.Forms.TextBox tbPass;
    }
}