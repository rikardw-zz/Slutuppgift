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

namespace Slutuppgift
{
    public partial class WebForm3 : System.Web.UI.Page
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

        protected List<string> HämtaJaktlag()
        {
            XElement älgskötselområde = XElement.Load(path);

            var olikaJaktlag = (from a in älgskötselområde.Elements("jaktlag").Elements("jaktlagsnamn")
                                select (string)a).Distinct().ToList<string>();
            return olikaJaktlag;
        }
        void LaddaJaktlag(List<string> lista)
        {
            foreach (string s in lista)
                lbjaktlag.Items.Add(s);
        }

        private void LäggTillAvskutning(string jaktlagsnamn, string avskutning)
        {
            XElement älgskötselområde = XElement.Load(path);

            var aktuelltAvskutning = (from a in älgskötselområde.Elements("jaktlag")
                                      where (string)a.Element("jaktlagsnamn") == jaktlagsnamn
                                      select a).Single();
            
                        ((XElement)aktuelltAvskutning).Add(new XElement("avskutning",
                            new XElement("namn", skytt.Text),
                            new XElement("datum", datum.Text),
                            new XElement("kön", kön.Text),
                            new XElement("vikt", vikt.Text),
                            new XElement("taggar", taggar.Text),
                            new XElement("ålder", ålder.Text)));
                            
            älgskötselområde.Save(path);
          /*  skytt.Text = String.Empty;
            datum.Text = String.Empty;
            kön.Text = String.Empty;
            vikt.Text = String.Empty;
            taggar.Text = String.Empty;
            ålder.Text = String.Empty;   
          */ 
        }
      
        protected void submit_Click(object sender, EventArgs e)
        {

            string jaktlag = lbjaktlag.SelectedItem.ToString();
            string skyttnamn = skytt.Text;

            LäggTillAvskutning(jaktlag, skyttnamn);
        }    
    }
}