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
    public partial class WebForm2 : System.Web.UI.Page
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
                jaktlagInfo.Items.Add(s);
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

            protected void jaktlagInfo_SelectedIndexChanged(object sender, EventArgs e)
            {
                List<string> jaktledarinfo = new List<string>();
                jaktledarinfo = HämtaJaktledare(jaktlagInfo.Text);
                getjaktledarnamn.Text = jaktledarinfo[0];
                getepost.Text = jaktledarinfo[1];
                gettelefon.Text = jaktledarinfo[2];
                getfalldaalghanar.Text = HämtaSkjutnaHanar().ToString();
                getfalldaalghonor.Text = HämtaSkjutnaHonor().ToString();
                getfalldahankalvar.Text = HämtaSkjutnaHanKalvar().ToString();
                getfalldahonkalvar.Text = HämtaSkjutnaHonKalvar().ToString();
            }

            protected double HämtaSkjutnaHonor()
            {
                string valtjaktlag = jaktlagInfo.SelectedItem.ToString();
                string strFileName = Server.MapPath("Jaktlag.xml");
                XDocument xmlDoc = XDocument.Load(strFileName);

                var aktuelltJaktlag = (from a in xmlDoc.Descendants("jaktlag")
                                     where (string)a.Element("jaktlagsnamn") == valtjaktlag
                                     select a).Single();

                var xmlValue = (from a in aktuelltJaktlag.Elements("avskutning")
                                where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hona"
                                select (a.Element("Hona"))).Count();
                return xmlValue;

            }

            protected double HämtaSkjutnaHanar()
            {
                string valtjaktlag = jaktlagInfo.SelectedItem.ToString();
                string strFileName = Server.MapPath("Jaktlag.xml");
                XDocument xmlDoc = XDocument.Load(strFileName);

                var aktuelltJaktlag = (from a in xmlDoc.Descendants("jaktlag")
                                       where (string)a.Element("jaktlagsnamn") == valtjaktlag
                                       select a).Single();

                var xmlValue = (from a in aktuelltJaktlag.Elements("avskutning")
                                where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hane"
                                select (a.Element("Hane"))).Count();
                return xmlValue;

            }

          /*  protected double HämtaSkjutnaKalvar()
            {
                string valtjaktlag = jaktlagInfo.SelectedItem.ToString();
                string strFileName = Server.MapPath("Jaktlag.xml");
                XDocument xmlDoc = XDocument.Load(strFileName);

                var aktuelltJaktlag = (from a in xmlDoc.Descendants("jaktlag")
                                       where (string)a.Element("jaktlagsnamn") == valtjaktlag
                                       select a).Single();

                var xmlValue = (from a in aktuelltJaktlag.Elements("avskutning")
                                where (int)a.Element("ålder") == 0
                                select (a.Element("ålder"))).Count();
                return xmlValue;               
            }    */
            protected double HämtaSkjutnaHanKalvar()
            {
                string valtjaktlag = jaktlagInfo.SelectedItem.ToString();
                string strFileName = Server.MapPath("Jaktlag.xml");
                XDocument xmlDoc = XDocument.Load(strFileName);

                var aktuelltJaktlag = (from a in xmlDoc.Descendants("jaktlag")
                                       where (string)a.Element("jaktlagsnamn") == valtjaktlag
                                       select a).Single();

                var xmlValue = (from a in aktuelltJaktlag.Elements("avskutning")
                                where (int)a.Element("ålder") == 0 && (string)a.Element("kön") == "Hane"
                                select (a.Element("ålder"))).Count();
                return xmlValue;
            }

            protected double HämtaSkjutnaHonKalvar()
            {
                string valtjaktlag = jaktlagInfo.SelectedItem.ToString();
                string strFileName = Server.MapPath("Jaktlag.xml");
                XDocument xmlDoc = XDocument.Load(strFileName);

                var aktuelltJaktlag = (from a in xmlDoc.Descendants("jaktlag")
                                       where (string)a.Element("jaktlagsnamn") == valtjaktlag
                                       select a).Single();

                var xmlValue = (from a in aktuelltJaktlag.Elements("avskutning")
                                where (int)a.Element("ålder") == 0 && (string)a.Element("kön") == "Hona"
                                select (a.Element("ålder"))).Count();
                return xmlValue;
            }   
    }
}