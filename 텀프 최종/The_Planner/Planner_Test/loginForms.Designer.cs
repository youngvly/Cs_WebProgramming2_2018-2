namespace The_Planner
{
    partial class loginForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signupControls1 = new The_Planner.signupControls();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.signupControls1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.signupLink);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Controls.Add(this.idbox);
            this.panel1.Location = new System.Drawing.Point(218, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 436);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Planner";
            // 
            // signupLink
            // 
            this.signupLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.signupLink.AutoSize = true;
            this.signupLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.signupLink.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signupLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.signupLink.Location = new System.Drawing.Point(223, 371);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(82, 22);
            this.signupLink.TabIndex = 3;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "SignUp!";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("나눔스퀘어", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(136, 275);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(254, 61);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginBox_Click);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Font = new System.Drawing.Font("나눔스퀘어", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.passbox.Location = new System.Drawing.Point(53, 221);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(423, 29);
            this.passbox.TabIndex = 2;
            this.passbox.Text = "  Password";
            // 
            // idbox
            // 
            this.idbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.idbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idbox.Font = new System.Drawing.Font("나눔스퀘어", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.idbox.Location = new System.Drawing.Point(53, 176);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(423, 29);
            this.idbox.TabIndex = 1;
            this.idbox.Text = "  ID";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::The_Planner.Properties.Resources.noun_Close_1590727_사본;
            this.button2.Location = new System.Drawing.Point(929, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 32);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Image = global::The_Planner.Properties.Resources.noun_planner_1784243;
            this.label1.Location = new System.Drawing.Point(447, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "    ";
            // 
            // signupControls1
            // 
            this.signupControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.signupControls1.Location = new System.Drawing.Point(-58, -142);
            this.signupControls1.Name = "signupControls1";
            this.signupControls1.Size = new System.Drawing.Size(682, 672);
            this.signupControls1.TabIndex = 5;
            // 
            // loginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(978, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForms";
            this.Text = "loginForms";
            this.Load += new System.EventHandler(this.loginForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel signupLink;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private signupControls signupControls1;
    }
}