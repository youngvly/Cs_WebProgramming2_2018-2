using Planner_Test.domain;

namespace Planner_Test
{
    partial class Hello
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent(Users user)
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.logoButton = new System.Windows.Forms.Button();
            this.APButton = new System.Windows.Forms.Button();
            this.MonthButton = new System.Windows.Forms.Button();
            this.TodoButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainUserControl = new Planner_Test.UserControl1();
            this.todoControl1 = new Planner_Test.todoControl();
            this.monthControl1 = new Planner_Test.monthControl(user);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.logoButton);
            this.panel1.Controls.Add(this.APButton);
            this.panel1.Controls.Add(this.MonthButton);
            this.panel1.Controls.Add(this.TodoButton);
            this.panel1.Controls.Add(this.MainButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.exitButton.Image = global::Planner_Test.Properties.Resources.noun_Close_1590727_사본;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(25, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 25);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.logoutButton.Image = global::Planner_Test.Properties.Resources.noun_logout_1155288_사본;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(25, 388);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(107, 25);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // logoButton
            // 
            this.logoButton.FlatAppearance.BorderSize = 0;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Font = new System.Drawing.Font("나눔스퀘어", 10F);
            this.logoButton.ForeColor = System.Drawing.Color.White;
            this.logoButton.Image = global::Planner_Test.Properties.Resources.noun_planner_1784243;
            this.logoButton.Location = new System.Drawing.Point(12, 607);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(113, 100);
            this.logoButton.TabIndex = 0;
            this.logoButton.Text = "The Planner";
            this.logoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoButton.UseVisualStyleBackColor = true;
            // 
            // APButton
            // 
            this.APButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.APButton.FlatAppearance.BorderSize = 0;
            this.APButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APButton.Font = new System.Drawing.Font("나눔스퀘어", 10F);
            this.APButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.APButton.Image = global::Planner_Test.Properties.Resources.noun_Meeting_1580032;
            this.APButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APButton.Location = new System.Drawing.Point(0, 312);
            this.APButton.Name = "APButton";
            this.APButton.Size = new System.Drawing.Size(145, 70);
            this.APButton.TabIndex = 3;
            this.APButton.Text = "      Make AP";
            this.APButton.UseVisualStyleBackColor = true;
            this.APButton.Click += new System.EventHandler(this.APButton_Click);
            // 
            // MonthButton
            // 
            this.MonthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MonthButton.FlatAppearance.BorderSize = 0;
            this.MonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthButton.Font = new System.Drawing.Font("나눔스퀘어", 10F);
            this.MonthButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.MonthButton.Image = global::Planner_Test.Properties.Resources.noun_calender4;
            this.MonthButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MonthButton.Location = new System.Drawing.Point(0, 242);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(145, 70);
            this.MonthButton.TabIndex = 2;
            this.MonthButton.Text = "    Month";
            this.MonthButton.UseVisualStyleBackColor = true;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // TodoButton
            // 
            this.TodoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TodoButton.FlatAppearance.BorderSize = 0;
            this.TodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoButton.Font = new System.Drawing.Font("나눔스퀘어", 10F);
            this.TodoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.TodoButton.Image = global::Planner_Test.Properties.Resources.noun_Check_18137011;
            this.TodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodoButton.Location = new System.Drawing.Point(0, 172);
            this.TodoButton.Name = "TodoButton";
            this.TodoButton.Size = new System.Drawing.Size(145, 70);
            this.TodoButton.TabIndex = 1;
            this.TodoButton.Text = "    Todo";
            this.TodoButton.UseVisualStyleBackColor = true;
            this.TodoButton.Click += new System.EventHandler(this.TodoButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Font = new System.Drawing.Font("나눔스퀘어", 11F);
            this.MainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.MainButton.Image = global::Planner_Test.Properties.Resources.noun_main_19020231;
            this.MainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.Location = new System.Drawing.Point(0, 102);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(145, 70);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Main";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(60)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.usernameText);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 100);
            this.panel2.TabIndex = 1;
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(60)))), ((int)(((byte)(132)))));
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.usernameText.Location = new System.Drawing.Point(25, 51);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 19);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "User Name";
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(60)))), ((int)(((byte)(132)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.textBox1.Location = new System.Drawing.Point(25, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hello";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainUserControl
            // 
            this.mainUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.mainUserControl.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainUserControl.Location = new System.Drawing.Point(142, 0);
            this.mainUserControl.Name = "mainUserControl";
            this.mainUserControl.Size = new System.Drawing.Size(833, 719);
            this.mainUserControl.TabIndex = 5;
            // 
            // todoControl1
            // 
            this.todoControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.todoControl1.Location = new System.Drawing.Point(143, 1);
            this.todoControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoControl1.Name = "todoControl1";
            this.todoControl1.Size = new System.Drawing.Size(833, 719);
            this.todoControl1.TabIndex = 6;
            // 
            // monthControl1
            // 
            this.monthControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.monthControl1.Location = new System.Drawing.Point(143, 0);
            this.monthControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthControl1.Name = "monthControl1";
            this.monthControl1.Size = new System.Drawing.Size(833, 719);
            this.monthControl1.TabIndex = 7;
            this.monthControl1.Load += new System.EventHandler(this.monthControl1_Load);
            // 
            // Hello
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 719);
            this.Controls.Add(this.monthControl1);
            this.Controls.Add(this.todoControl1);
            this.Controls.Add(this.mainUserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hello";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button TodoButton;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Button MonthButton;
        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private UserControl1 mainUserControl;
        private todoControl todoControl1;
        private monthControl monthControl1;
    }
}

