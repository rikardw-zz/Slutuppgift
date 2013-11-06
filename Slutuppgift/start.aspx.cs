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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            skjutnahanar.Text = HämtaSkjutnaHanar().ToString() + "st";
            skjutnahonor.Text = HämtaSkjutnaHonor().ToString() + "st";
            skjutnahankalvar.Text = HämtaSkjutnaHanKalvar().ToString() + "st";
            skjutnahonkalvar.Text = HämtaSkjutnaHonKalvar().ToString() + "st";
            snittvikthanar.Text = HämtaViktHane().ToString() + " kg";
            snittvikthonor.Text = HämtaViktHona().ToString() +" kg";
            snittviktkalvar.Text = HämtaViktKalv().ToString() + " kg";
            snittalderhanar.Text = HämtaÅlderHanar().ToString() + " år";
            snittalderhonor.Text = HämtaÅlderHonor().ToString() + " år";
            taggar.Text = HämtaTaggar().ToString();
           // skjutnahanar.Text = HämtaSkjutnaHanar().ToString();
        }

        protected double HämtaViktHane()
        {
            
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return xmlValue;
        }

        protected double HämtaViktHona()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hona"
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return xmlValue;
        }

        protected double HämtaViktKalv()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return xmlValue;
        }

        protected double HämtaÅlderHanar()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("ålder").Value))).Average();
            return xmlValue;
        }

        protected double HämtaÅlderHonor()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hona"
                            select (double.Parse(a.Element("ålder").Value))).Average();
            return xmlValue;
        }

        protected double HämtaTaggar()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("taggar").Value))).Average();
            return xmlValue;
        }




       protected double HämtaSkjutnaHanar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") > 0
                            select (a.Element("Hane"))).Count();
            return xmlValue;
        }

        protected double HämtaSkjutnaHonor()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") > 0
                            select (a.Element("Hona"))).Count();
            return xmlValue;
        }

        protected double HämtaSkjutnaHanKalvar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0
                            select (a.Element("Hane"))).Count();
            return xmlValue;
        }
        protected double HämtaSkjutnaHonKalvar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0
                            select (a.Element("Hona"))).Count();
            return xmlValue;
        }
    }
}