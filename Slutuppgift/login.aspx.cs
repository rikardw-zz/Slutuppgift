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
using System.Web.Security;


namespace Slutuppgift
{
    public partial class WebForm4 : System.Web.UI.Page
    {      
        protected void Page_Load(object sender, EventArgs e)  
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            XElement jaktlag = XElement.Load(Path.Combine(HostingEnvironment.ApplicationPhysicalPath, @"Jaktlag.xml"));
            var xmlValue = (from a in jaktlag.Descendants("rapportör")
                                          where (string)a.Element("användarnamn") == name.Text && (string)a.Element("lösenord") == password.Text
                                          select a.Element("rapportör")).Count();
            if (xmlValue > 0)
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