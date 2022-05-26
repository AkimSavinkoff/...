
namespace VKR01
{
    partial class Form_menu_sot
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butGuide = new System.Windows.Forms.Button();
            this.butTasks = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butOborud = new System.Windows.Forms.Button();
            this.butRaspis = new System.Windows.Forms.Button();
            this.butVedomost = new System.Windows.Forms.Button();
            this.butAddPrak = new System.Windows.Forms.Button();
            this.exitprog = new System.Windows.Forms.ToolStripMenuItem();
            this.infoabout = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.exitacc = new System.Windows.Forms.ToolStripMenuItem();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butAddSot = new System.Windows.Forms.Button();
            this.butDelSot = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(519, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 415);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butGuide);
            this.groupBox1.Controls.Add(this.butTasks);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.butOborud);
            this.groupBox1.Controls.Add(this.butRaspis);
            this.groupBox1.Controls.Add(this.butVedomost);
            this.groupBox1.Controls.Add(this.butAddPrak);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 630);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы управления";
            // 
            // butGuide
            // 
            this.butGuide.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butGuide.Location = new System.Drawing.Point(35, 438);
            this.butGuide.Name = "butGuide";
            this.butGuide.Size = new System.Drawing.Size(266, 42);
            this.butGuide.TabIndex = 9;
            this.butGuide.Text = "Справочники";
            this.butGuide.UseVisualStyleBackColor = true;
            // 
            // butTasks
            // 
            this.butTasks.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butTasks.Location = new System.Drawing.Point(35, 136);
            this.butTasks.Name = "butTasks";
            this.butTasks.Size = new System.Drawing.Size(266, 46);
            this.butTasks.TabIndex = 5;
            this.butTasks.Text = "Задачи";
            this.butTasks.UseVisualStyleBackColor = true;
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
            // butOborud
            // 
            this.butOborud.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butOborud.Location = new System.Drawing.Point(35, 364);
            this.butOborud.Name = "butOborud";
            this.butOborud.Size = new System.Drawing.Size(266, 42);
            this.butOborud.TabIndex = 3;
            this.butOborud.Text = "Учет оборудования";
            this.butOborud.UseVisualStyleBackColor = true;
            // 
            // butRaspis
            // 
            this.butRaspis.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRaspis.Location = new System.Drawing.Point(35, 288);
            this.butRaspis.Name = "butRaspis";
            this.butRaspis.Size = new System.Drawing.Size(266, 44);
            this.butRaspis.TabIndex = 2;
            this.butRaspis.Text = "Расписание";
            this.butRaspis.UseVisualStyleBackColor = true;
            // 
            // butVedomost
            // 
            this.butVedomost.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butVedomost.Location = new System.Drawing.Point(35, 214);
            this.butVedomost.Name = "butVedomost";
            this.butVedomost.Size = new System.Drawing.Size(266, 42);
            this.butVedomost.TabIndex = 1;
            this.butVedomost.Text = "Ведомость";
            this.butVedomost.UseVisualStyleBackColor = true;
            // 
            // butAddPrak
            // 
            this.butAddPrak.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butAddPrak.Location = new System.Drawing.Point(35, 58);
            this.butAddPrak.Name = "butAddPrak";
            this.butAddPrak.Size = new System.Drawing.Size(266, 46);
            this.butAddPrak.TabIndex = 0;
            this.butAddPrak.Text = "Список практикантов";
            this.butAddPrak.UseVisualStyleBackColor = true;
            this.butAddPrak.Click += new System.EventHandler(this.butAddPrak_Click);
            // 
            // exitprog
            // 
            this.exitprog.Name = "exitprog";
            this.exitprog.Size = new System.Drawing.Size(67, 24);
            this.exitprog.Text = "Выход";
            // 
            // infoabout
            // 
            this.infoabout.Name = "infoabout";
            this.infoabout.Size = new System.Drawing.Size(277, 26);
            this.infoabout.Text = "Сведения об организации";
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
            // contacts
            // 
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(277, 26);
            this.contacts.Text = "Контакты";
            // 
            // exitacc
            // 
            this.exitacc.Name = "exitacc";
            this.exitacc.Size = new System.Drawing.Size(220, 26);
            this.exitacc.Text = "Выйти из аккаунта";
            // 
            // account
            // 
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitacc});
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(77, 24);
            this.account.Text = "Аккаунт";
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
            this.menuStrip1.Size = new System.Drawing.Size(1438, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // butAddSot
            // 
            this.butAddSot.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butAddSot.Location = new System.Drawing.Point(580, 580);
            this.butAddSot.Name = "butAddSot";
            this.butAddSot.Size = new System.Drawing.Size(266, 42);
            this.butAddSot.TabIndex = 6;
            this.butAddSot.Text = "Добавить сотрудника";
            this.butAddSot.UseVisualStyleBackColor = true;
            // 
            // butDelSot
            // 
            this.butDelSot.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butDelSot.Location = new System.Drawing.Point(1047, 580);
            this.butDelSot.Name = "butDelSot";
            this.butDelSot.Size = new System.Drawing.Size(266, 42);
            this.butDelSot.TabIndex = 7;
            this.butDelSot.Text = "Удалить сотрудника";
            this.butDelSot.UseVisualStyleBackColor = true;
            // 
            // Form_menu_sot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1438, 658);
            this.Controls.Add(this.butDelSot);
            this.Controls.Add(this.butAddSot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_menu_sot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ГЛАВНОЕ МЕНЮ";
            this.Load += new System.EventHandler(this.Form_menu_sot_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butOborud;
        private System.Windows.Forms.Button butRaspis;
        private System.Windows.Forms.Button butVedomost;
        private System.Windows.Forms.Button butAddPrak;
        private System.Windows.Forms.ToolStripMenuItem exitprog;
        private System.Windows.Forms.ToolStripMenuItem infoabout;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.ToolStripMenuItem contacts;
        private System.Windows.Forms.ToolStripMenuItem exitacc;
        private System.Windows.Forms.ToolStripMenuItem account;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button butTasks;
        private System.Windows.Forms.Button butGuide;
        private System.Windows.Forms.Button butAddSot;
        private System.Windows.Forms.Button butDelSot;
    }
}