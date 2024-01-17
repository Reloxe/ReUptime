using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReUptime
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string smtphostvar;
        public string smtpportvar;
        public string smtpusernamevar;
        public string smtpasswordvar;
        public string mailfromvar;
        public string alertmailvar;

        private void button1_Click(object sender, EventArgs e)
        {
            smtphostvar = smtpbox.Text;
            smtpportvar = smtpport.Text;
            smtpusernamevar = usernamee.Text;
            smtpasswordvar = passowrd.Text;
            mailfromvar = mailfromm.Text;
            alertmailvar = alertmail.Text;


            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
