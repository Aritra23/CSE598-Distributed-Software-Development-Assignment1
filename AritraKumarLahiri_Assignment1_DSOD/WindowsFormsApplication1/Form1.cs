using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // event generated for browsing on the web
        {
            webBrowser1.Navigate(textBox1.Text); // using the navigate function to run the url on the web browser
        }

        private void button2_Click(object sender, EventArgs e) // event generated for implementation of encryption and decryption function
        {
            ServiceReference2.ServiceClient ob = new ServiceReference2.ServiceClient(); // adding a service client reference object
            string s = ob.Encrypt(textBox2.Text); // using the encrypt function
            textBox3.Text = s;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference3.ServiceClient ob = new ServiceReference3.ServiceClient();
            string t = ob.getStockquote(textBox4.Text);
            textBox5.Text = t;
        }


    }
}
