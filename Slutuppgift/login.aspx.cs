using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Web.Security; //möjliggör inloggning


namespace Slutuppgift
{
    public partial class WebForm4 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)  
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (name.Text == "Admin" && password.Text == "123")
            {
                FormsAuthentication.RedirectFromLoginPage(name.Text, false);             
            }
            else
            {
                error.Text = "Du har angett fel användarnamn eller lösenord.";
            }
        }

        

    }
}