using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ReUptime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            HttpClient client = new HttpClient();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        Form2 ozelayarar = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            ozelayarar.ShowDialog();
        }

        private void startbuton_Click(object sender, EventArgs e)
        {
            startbuton.Enabled = false;
            client.DefaultRequestHeaders.Add("User-Agent", useragent.Text);
            if (interval.Text == "" || url.Text == "" || useragent.Text == "")
            {
                MessageBox.Show("Fill in all entries !");
                return;
            }
            try
            {
               timer1.Interval = Convert.ToInt32(interval.Text);
            } catch (Exception ex) {
                MessageBox.Show("Enter the interval in milliseconds format example: 10000");
                return;
            }

            timer1.Start();
        }

        private void stopbuton_Click(object sender, EventArgs e)
        {
            startbuton.Enabled = true;
            timer1.Stop();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                HttpResponseMessage response = await client.GetAsync(url.Text);
                stopwatch.Stop();
                if (response.IsSuccessStatusCode)
                {
                    listBox1.Items.Add("Status Code: " + (int)response.StatusCode + " | Response Delay: " + stopwatch.ElapsedMilliseconds + " MS" + " | Request Time:" + DateTime.Now);
                }
                else
                {
                    
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(ozelayarar.mailfromvar); 
                    mailMessage.To.Add(ozelayarar.alertmailvar); 
                    mailMessage.Subject = $"ReUptime - {(int)response.StatusCode} Alert";
                    mailMessage.Body = $"Hello, \n {url.Text} \n -- Request response information -- \n Status Code: {(int)response.StatusCode} \n Response Delay {stopwatch.ElapsedMilliseconds} MS \n Request Time: {DateTime.Now} \n This email was sent automatically by ReUptime due to an incorrect response from the site.";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Host = ozelayarar.smtphostvar; 
                    smtpClient.Port = Convert.ToInt32(ozelayarar.smtpportvar); 
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(ozelayarar.smtpusernamevar, ozelayarar.smtpasswordvar);
                    smtpClient.EnableSsl = true;

                    try
                    {
                         smtpClient.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata" + ex);
                    }
                    
                    listBox1.Items.Add("Status Code: " + (int)response.StatusCode + " | Response Delay: " + stopwatch.ElapsedMilliseconds + " MS" + " | Request Time:" + DateTime.Now);
                }

            }
            catch (Exception ex) {
                
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(ozelayarar.mailfromvar);
                mailMessage.To.Add(ozelayarar.alertmailvar);
                mailMessage.Subject = $"ReUptime - Response Alert";
                mailMessage.Body = $"Hello, \n ${url.Text} \n A request was sent to the url but a problem was encountered. ERROR: ${ex} \n This email was sent automatically by ReUptime due to an incorrect response from the site.";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = ozelayarar.smtphostvar;
                smtpClient.Port = Convert.ToInt32(ozelayarar.smtpportvar);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(ozelayarar.smtpusernamevar, ozelayarar.smtpasswordvar);
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Mail hatası: " + exx);
                }
                
                listBox1.Items.Add("Req Erorr" + " | " + DateTime.Now);
            }
  


        }

    }
}
