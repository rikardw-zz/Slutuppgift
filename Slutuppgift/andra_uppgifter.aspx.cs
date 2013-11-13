using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Web.Hosting;
using System.Configuration;
using System.IO;

namespace Slutuppgift
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        private string path = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, @"Jaktlag.xml");
            if (!Page.IsPostBack) {
                aktuelltJaktlag();  
            }                                          
        }       

        public List<string> HämtaJaktledare(string jaktlagsnamn)
        {
                List<string> jaktledarinfo = new List<string>();
                XElement jaktlag = XElement.Load(path);
                XElement aktuellJaktledare = (from a in jaktlag.Elements("jaktlag")
                                              where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                              select a.Element("jaktledare")).Single();
                
                jaktledarinfo.Add(aktuellJaktledare.Element("namn").Value);
                jaktledarinfo.Add(aktuellJaktledare.Element("email").Value);
                jaktledarinfo.Add(aktuellJaktledare.Element("telefon").Value);                                   
            return jaktledarinfo;
        }      

        public List<string> HämtaRapportör(string jaktlagsnamn)
        {
            XElement jaktlag = XElement.Load(path);          
            XElement aktuellJaktledare = (from a in jaktlag.Elements("jaktlag")
                                          where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                          select a.Element("rapportör")).Single();

            List<string> rapportörInfo = new List<string>();
            rapportörInfo.Add(aktuellJaktledare.Element("namn").Value);
            rapportörInfo.Add(aktuellJaktledare.Element("email").Value);
            rapportörInfo.Add(aktuellJaktledare.Element("telefon").Value);

            return rapportörInfo;
        }

        private void UppdateraJaktledare(string jaktlagsnamn)
        {
                XElement älgskötselområde = XElement.Load(path);

                XElement aktuellJaktledare = (from a in älgskötselområde.Elements("jaktlag")
                                              where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                              select a.Element("jaktledare")).Single();

                aktuellJaktledare.SetElementValue("namn", txtJaktledare.Text);
                aktuellJaktledare.SetElementValue("email", txtEpostJaktledare.Text);
                aktuellJaktledare.SetElementValue("telefon", txtTelefonJaktledare.Text);
                älgskötselområde.Save(path);
                aktuelltJaktlag();
    
        }

        private void UppdateraRapportör(string jaktlagsnamn)
        {
                XElement jaktområde = XElement.Load(path);
                XElement aktuellRapportör = (from a in jaktområde.Elements("jaktlag")
                                             where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                             select a.Element("rapportör")).Single();

                aktuellRapportör.SetElementValue("namn", txtRapportör.Text);
                aktuellRapportör.SetElementValue("email", txtEpostRapportör.Text);
                aktuellRapportör.SetElementValue("telefon", txtTelefonRapportör.Text);
                jaktområde.Save(path);            
        }

        protected void submitRapportör_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                {
                   string jaktlag = inloggadJaktlag();
                   UppdateraRapportör(jaktlag);            
                   UppdateraJaktledare(jaktlag);
                }
        }

        protected void aktuelltJaktlag() 
        {
            string inloggadNamn = HttpContext.Current.User.Identity.Name.ToString();

            XElement jaktområde = XElement.Load(path);
            XElement aktuelltJaktlag = (from a in jaktområde.Descendants("rapportör")
                                         where (string)a.Element("användarnamn") == inloggadNamn
                                         select a.Parent).Single();

            txtJaktledare.Text = aktuelltJaktlag.Element("jaktledare").Element("namn").Value;
            txtEpostJaktledare.Text = aktuelltJaktlag.Element("jaktledare").Element("email").Value;
            txtTelefonJaktledare.Text = aktuelltJaktlag.Element("jaktledare").Element("telefon").Value;

            txtRapportör.Text = aktuelltJaktlag.Element("rapportör").Element("namn").Value;
            txtEpostRapportör.Text = aktuelltJaktlag.Element("rapportör").Element("email").Value;
            txtTelefonRapportör.Text = aktuelltJaktlag.Element("rapportör").Element("telefon").Value;
        }

        protected string inloggadJaktlag() { 
        
            string inloggadNamn = HttpContext.Current.User.Identity.Name.ToString();

            XElement jaktområde = XElement.Load(path);
            XElement aktuelltJaktlag = (from a in jaktområde.Descendants("rapportör")
                                         where (string)a.Element("användarnamn") == inloggadNamn
                                        select a.Parent).Single().Element("jaktlagsnamn");
            return aktuelltJaktlag.Value;
        }
    }
}