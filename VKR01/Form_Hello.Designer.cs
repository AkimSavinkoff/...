
namespace VKR01
{
    partial class Form_Hello
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
            this.label2 = new System.Windows.Forms.Label();
            this.butSot = new System.Windows.Forms.Button();
            this.butStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать";
            // 
            // butSot
            // 
            this.butSot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSot.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butSot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSot.Location = new System.Drawing.Point(101, 118);
            this.butSot.Name = "butSot";
            this.butSot.Size = new System.Drawing.Size(171, 120);
            this.butSot.TabIndex = 2;
            this.butSot.Text = "Практикант";
            this.butSot.UseVisualStyleBackColor = true;
            this.butSot.Click += new System.EventHandler(this.butSot_Click);
            // 
            // butStud
            // 
            this.butStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butStud.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butStud.Location = new System.Drawing.Point(101, 244);
            this.butStud.Name = "butStud";
            this.butStud.Size = new System.Drawing.Size(171, 122);
            this.butStud.TabIndex = 3;
            this.butStud.Text = "Сотрудник";
            this.butStud.UseVisualStyleBackColor = true;
            this.butStud.Click += new System.EventHandler(this.butStud_Click);
            // 
            // Form_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(373, 420);
            this.Controls.Add(this.butStud);
            this.Controls.Add(this.butSot);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОКНО ПРИВЕТСТВИЯ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSot;
        private System.Windows.Forms.Button butStud;
    }
}

