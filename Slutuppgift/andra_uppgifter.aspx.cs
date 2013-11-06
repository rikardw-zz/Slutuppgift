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
            if (!IsPostBack)
            {
                LaddaJaktlag(HämtaJaktlag());
            }        
        }

        void LaddaJaktlag(List<string> lista)
        {
            foreach (string s in lista)
                jaktledare.Items.Add(s);
        }

        protected List<string> HämtaJaktlag()
        {
            XElement älgskötselområde = XElement.Load(path);

            var olikaJaktlag = (from a in älgskötselområde.Elements("jaktlag").Elements("jaktlagsnamn")
                                select (string)a).Distinct().ToList<string>();
            return olikaJaktlag;
        }

        public List<string> HämtaJaktledare(string jaktlagsnamn)
        {
            XElement jaktlag = XElement.Load(path);
            //har hela jaktlagselement,består av tre olika saker
            XElement aktuellJaktledare = (from a in jaktlag.Elements("jaktlag")
                                          where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                          select a.Element("jaktledare")).Single();

            List<string> jaktledarinfo = new List<string>();
            jaktledarinfo.Add(aktuellJaktledare.Element("namn").Value);
            jaktledarinfo.Add(aktuellJaktledare.Element("email").Value);
            jaktledarinfo.Add(aktuellJaktledare.Element("telefon").Value);
            

            return jaktledarinfo;
        }

        protected void jaktledare_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> jaktledarinfo = new List<string>();
            List<string> rapportörinfo = new List<string>();
            jaktledarinfo = HämtaJaktledare(jaktledare.Text);
            txtJaktledare.Text = jaktledarinfo[0];
            txtEpostJaktledare.Text = jaktledarinfo[1];
            txtTelefonJaktledare.Text = jaktledarinfo[2];

            
            rapportörinfo = HämtaRapportör(jaktledare.Text);
            txtRapportör.Text = rapportörinfo[0];
            txtEpostRapportör.Text = rapportörinfo[1];
            txtTelefonRapportör.Text = rapportörinfo[2];
            
        }

        public List<string> HämtaRapportör(string jaktlagsnamn)
        {
            XElement jaktlag = XElement.Load(path);
            //har hela jaktlagselement,består av tre olika saker
            XElement aktuellJaktledare = (from a in jaktlag.Elements("jaktlag")
                                          where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                          select a.Element("rapportör")).Single();

            List<string> rapportörInfo = new List<string>();
            rapportörInfo.Add(aktuellJaktledare.Element("namn").Value);
            rapportörInfo.Add(aktuellJaktledare.Element("email").Value);
            rapportörInfo.Add(aktuellJaktledare.Element("telefon").Value);

            return rapportörInfo;
        }

        protected void submitJaktledare_Click(object sender, EventArgs e)
        {
            string jaktlag = jaktledare.SelectedItem.ToString();
            UppdateraJaktledare(jaktlag);
        }

        private void UppdateraJaktledare(string jaktlagsnamn)
        {
            XElement älgskötselområde = XElement.Load(path);

            //denna som är tokig, 
            XElement aktuellJaktledare = (from a in älgskötselområde.Elements("jaktlag")
                                          where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                          select a.Element("jaktledare")).Single();

           aktuellJaktledare.SetElementValue("namn", txtJaktledare.Text);
           aktuellJaktledare.SetElementValue("email", txtEpostJaktledare.Text);
           aktuellJaktledare.SetElementValue("telefon", txtTelefonJaktledare.Text);
            älgskötselområde.Save(path);
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
            string jaktlag = jaktledare.SelectedItem.ToString();
            UppdateraRapportör(jaktlag);
        }
	

    }
}