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
            updateInfo();                  
        }

        protected double HämtaViktHane()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");      
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaViktHona()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hona"
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return Convert.ToInt32(xmlValue);            
        }

        protected double HämtaViktKalv()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0
                            select (double.Parse(a.Element("vikt").Value))).Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaÅlderHanar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("ålder").Value))).Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaÅlderHonor()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hona"
                            select (double.Parse(a.Element("ålder").Value))).Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaTaggar()
        {

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane"
                            select (double.Parse(a.Element("taggar").Value))).Average();
            return Convert.ToInt32(xmlValue);
        }

       protected double HämtaSkjutnaHanar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")                            
                            where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hane"
                            select (a.Element("Hane"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaSkjutnaHonor()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hona"
                            select (a.Element("Hona"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaSkjutnaHanKalvar()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0 && (string)a.Element("kön") == "Hane"
                            select (a.Element("Hane"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaSkjutnaHonKalvar()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);

            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);            
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0 && (string)a.Element("kön") == "Hona" && 
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (a.Element("Hona"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected void väljår_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        protected void updateInfo() 
        {
            skjutnahanar.Text = HämtaSkjutnaHanar().ToString() + "st";
            skjutnahonor.Text = HämtaSkjutnaHonor().ToString() + "st";
            skjutnahankalvar.Text = HämtaSkjutnaHanKalvar().ToString() + "st";
            skjutnahonkalvar.Text = HämtaSkjutnaHonKalvar().ToString() + "st";
            snittvikthanar.Text = HämtaViktHane().ToString() + " kg";
            snittvikthonor.Text = HämtaViktHona().ToString() + " kg";
            snittviktkalvar.Text = HämtaViktKalv().ToString() + " kg";
            snittalderhanar.Text = HämtaÅlderHanar().ToString() + " år";
            snittalderhonor.Text = HämtaÅlderHonor().ToString() + " år";
            taggar.Text = HämtaTaggar().ToString() + " taggar";                            
        }
    }
}