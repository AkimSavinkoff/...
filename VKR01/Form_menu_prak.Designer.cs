
namespace VKR01
{
    partial class Form_menu_prak
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.exitacc = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.infoabout = new System.Windows.Forms.ToolStripMenuItem();
            this.contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprog = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account,
            this.information,
            this.exitprog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1421, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // account
            // 
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitacc});
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(77, 24);
            this.account.Text = "Аккаунт";
            // 
            // exitacc
            // 
            this.exitacc.Name = "exitacc";
            this.exitacc.Size = new System.Drawing.Size(220, 26);
            this.exitacc.Text = "Выйти из аккаунта";
            // 
            // information
            // 
            this.information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoabout,
            this.contacts});
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(81, 24);
            this.information.Text = "Справка";
            // 
            // infoabout
            // 
            this.infoabout.Name = "infoabout";
            this.infoabout.Size = new System.Drawing.Size(277, 26);
            this.infoabout.Text = "Сведения об организации";
            // 
            // contacts
            // 
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(277, 26);
            this.contacts.Text = "Контакты";
            // 
            // exitprog
            // 
            this.exitprog.Name = "exitprog";
            this.exitprog.Size = new System.Drawing.Size(67, 24);
            this.exitprog.Text = "Выход";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 608);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы управления";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(201, 81);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 36);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "label1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Учет оборудования";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Расписание";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ведомость";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задачи";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(493, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 415);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(12, 444);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(266, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Справочники";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_menu_prak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1421, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_menu_prak";
            this.Text = "МЕНЮ ПРАКТИКАНТОВ";
            this.Load += new System.EventHandler(this.Form_menu_prak_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem account;
        private System.Windows.Forms.ToolStripMenuItem exitacc;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.ToolStripMenuItem infoabout;
        private System.Windows.Forms.ToolStripMenuItem contacts;
        private System.Windows.Forms.ToolStripMenuItem exitprog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}