namespace ReUptime
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smtpbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smtpport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernamee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passowrd = new System.Windows.Forms.TextBox();
            this.labelpros = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mailfromm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.alertmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.smtpbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 61);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // smtpbox
            // 
            this.smtpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.smtpbox.Location = new System.Drawing.Point(3, 32);
            this.smtpbox.Name = "smtpbox";
            this.smtpbox.Size = new System.Drawing.Size(176, 23);
            this.smtpbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Host";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.smtpport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(200, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 61);
            this.panel2.TabIndex = 7;
            // 
            // smtpport
            // 
            this.smtpport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.smtpport.Location = new System.Drawing.Point(3, 32);
            this.smtpport.Name = "smtpport";
            this.smtpport.Size = new System.Drawing.Size(173, 23);
            this.smtpport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(51, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SMTP Port";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usernamee);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 61);
            this.panel3.TabIndex = 8;
            // 
            // usernamee
            // 
            this.usernamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.usernamee.Location = new System.Drawing.Point(3, 32);
            this.usernamee.Name = "usernamee";
            this.usernamee.Size = new System.Drawing.Size(173, 23);
            this.usernamee.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(31, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP Username";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passowrd);
            this.panel4.Controls.Add(this.labelpros);
            this.panel4.Location = new System.Drawing.Point(200, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 61);
            this.panel4.TabIndex = 9;
            // 
            // passowrd
            // 
            this.passowrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.passowrd.Location = new System.Drawing.Point(3, 32);
            this.passowrd.Name = "passowrd";
            this.passowrd.Size = new System.Drawing.Size(173, 23);
            this.passowrd.TabIndex = 1;
            // 
            // labelpros
            // 
            this.labelpros.AutoSize = true;
            this.labelpros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelpros.Location = new System.Drawing.Point(31, 0);
            this.labelpros.Name = "labelpros";
            this.labelpros.Size = new System.Drawing.Size(111, 17);
            this.labelpros.TabIndex = 0;
            this.labelpros.Text = "SMTP Password";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mailfromm);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 61);
            this.panel5.TabIndex = 7;
            // 
            // mailfromm
            // 
            this.mailfromm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mailfromm.Location = new System.Drawing.Point(3, 32);
            this.mailfromm.Name = "mailfromm";
            this.mailfromm.Size = new System.Drawing.Size(176, 23);
            this.mailfromm.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(57, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail From";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.alertmail);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(200, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 61);
            this.panel6.TabIndex = 8;
            // 
            // alertmail
            // 
            this.alertmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.alertmail.Location = new System.Drawing.Point(3, 32);
            this.alertmail.Name = "alertmail";
            this.alertmail.Size = new System.Drawing.Size(173, 23);
            this.alertmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(57, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alert Mail";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 242);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox smtpbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox smtpport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usernamee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox passowrd;
        private System.Windows.Forms.Label labelpros;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailfromm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox alertmail;
        private System.Windows.Forms.Label label5;
    }
}