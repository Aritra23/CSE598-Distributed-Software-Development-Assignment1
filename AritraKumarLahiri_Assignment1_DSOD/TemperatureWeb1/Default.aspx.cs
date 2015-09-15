﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e) // event generated by button click on the website application
    {
        ServiceReference1.Service1Client ob = new ServiceReference1.Service1Client(); // creating a service reference client object
        string x = TextBox1.Text;
        if (x != "")
        {
            int c = Int32.Parse(x); // parsing the value of integer in string
            int f = ob.c2f(c);
            TextBox2.Text = f.ToString(); // converting from integer to string type;
        }
        else
        {
            TextBox2.Text = "";

        }
    }


    protected void Button2_Click(object sender, EventArgs e)
   {
        ServiceReference1.Service1Client ob = new ServiceReference1.Service1Client();
      string y = TextBox3.Text;
        if (y != "")
        {
            int f = Int32.Parse(y); // parsing the value of integer to string
            int r = ob.f2c(f);
            TextBox4.Text = r.ToString(); // converting from integer to string type
        }
        else
        {
            TextBox4.Text = "";
        }
    }

}