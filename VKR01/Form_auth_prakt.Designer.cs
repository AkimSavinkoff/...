
namespace VKR01
{
    partial class Form_auth_prakt
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
            this.butBack1 = new System.Windows.Forms.Button();
            this.butLogPrak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassPrak = new System.Windows.Forms.TextBox();
            this.tbLogPrak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butBack1
            // 
            this.butBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack1.Location = new System.Drawing.Point(416, 409);
            this.butBack1.Name = "butBack1";
            this.butBack1.Size = new System.Drawing.Size(75, 29);
            this.butBack1.TabIndex = 15;
            this.butBack1.Text = "Назад";
            this.butBack1.UseVisualStyleBackColor = true;
            this.butBack1.Click += new System.EventHandler(this.butBack1_Click);
            // 
            // butLogPrak
            // 
            this.butLogPrak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogPrak.Location = new System.Drawing.Point(179, 293);
            this.butLogPrak.Name = "butLogPrak";
            this.butLogPrak.Size = new System.Drawing.Size(125, 34);
            this.butLogPrak.TabIndex = 14;
            this.butLogPrak.Text = "ВХОД";
            this.butLogPrak.UseVisualStyleBackColor = true;
            this.butLogPrak.Click += new System.EventHandler(this.butLogPrak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(199, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // tbPassPrak
            // 
            this.tbPassPrak.Location = new System.Drawing.Point(144, 240);
            this.tbPassPrak.Name = "tbPassPrak";
            this.tbPassPrak.PasswordChar = '*';
            this.tbPassPrak.PlaceholderText = "Пароль";
            this.tbPassPrak.Size = new System.Drawing.Size(195, 27);
            this.tbPassPrak.TabIndex = 11;
            // 
            // tbLogPrak
            // 
            this.tbLogPrak.Location = new System.Drawing.Point(144, 172);
            this.tbLogPrak.Name = "tbLogPrak";
            this.tbLogPrak.PlaceholderText = "Логин";
            this.tbLogPrak.Size = new System.Drawing.Size(195, 27);
            this.tbLogPrak.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 70);
            this.label2.TabIndex = 9;
            this.label2.Text = "Авторизация";
            // 
            // Form_auth_prakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.butBack1);
            this.Controls.Add(this.butLogPrak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassPrak);
            this.Controls.Add(this.tbLogPrak);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_auth_prakt";
            this.Text = "АВТОРИЗАЦИЯ ПРАКТИКАНТОВ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBack1;
        private System.Windows.Forms.Button butLogPrak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassPrak;
        private System.Windows.Forms.TextBox tbLogPrak;
        private System.Windows.Forms.Label label2;
    }
}