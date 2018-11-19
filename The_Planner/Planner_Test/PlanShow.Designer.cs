namespace Planner_Test
{
    partial class PlanShow
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
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.dropButton = new System.Windows.Forms.Button();
            this.AfterButton = new System.Windows.Forms.Button();
            this.BeforeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(218, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "일정수정";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(214, 304);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(101, 49);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "수정";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 20);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "분류선택";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(180, 233);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 21);
            this.endDate.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(110, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "종료일";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(180, 206);
            this.startDate.MaxDate = new System.DateTime(2050, 11, 12, 0, 0, 0, 0);
            this.startDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 21);
            this.startDate.TabIndex = 24;
            this.startDate.Value = new System.DateTime(2018, 11, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(110, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "시작일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(110, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "일정내용";
            // 
            // contents
            // 
            this.contents.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contents.Location = new System.Drawing.Point(180, 141);
            this.contents.Name = "contents";
            this.contents.Size = new System.Drawing.Size(200, 25);
            this.contents.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "일정명";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(180, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 25);
            this.title.TabIndex = 18;
            // 
            // dropButton
            // 
            this.dropButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.dropButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dropButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropButton.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dropButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dropButton.Location = new System.Drawing.Point(344, 304);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(101, 49);
            this.dropButton.TabIndex = 29;
            this.dropButton.Text = "삭제";
            this.dropButton.UseVisualStyleBackColor = false;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // AfterButton
            // 
            this.AfterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AfterButton.FlatAppearance.BorderSize = 0;
            this.AfterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AfterButton.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AfterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AfterButton.Location = new System.Drawing.Point(451, 169);
            this.AfterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AfterButton.Name = "AfterButton";
            this.AfterButton.Size = new System.Drawing.Size(36, 28);
            this.AfterButton.TabIndex = 31;
            this.AfterButton.Text = "▷";
            this.AfterButton.UseVisualStyleBackColor = true;
            this.AfterButton.Click += new System.EventHandler(this.AfterButton_Click);
            // 
            // BeforeButton
            // 
            this.BeforeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BeforeButton.FlatAppearance.BorderSize = 0;
            this.BeforeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeforeButton.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BeforeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BeforeButton.Location = new System.Drawing.Point(21, 169);
            this.BeforeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BeforeButton.Name = "BeforeButton";
            this.BeforeButton.Size = new System.Drawing.Size(36, 28);
            this.BeforeButton.TabIndex = 30;
            this.BeforeButton.Text = "◁";
            this.BeforeButton.UseVisualStyleBackColor = true;
            this.BeforeButton.Click += new System.EventHandler(this.BeforeButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(80, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 49);
            this.button2.TabIndex = 32;
            this.button2.Text = "창닫기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlanShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(515, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AfterButton);
            this.Controls.Add(this.BeforeButton);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanShow";
            this.Text = "ShowPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button AfterButton;
        private System.Windows.Forms.Button BeforeButton;
        private System.Windows.Forms.Button button2;
    }
}