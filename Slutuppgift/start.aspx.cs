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
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");      
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (double.Parse(a.Element("vikt").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaViktHona()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where ((string)a.Element("kön") == "Hona" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum)
                            select (double.Parse(a.Element("vikt").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);            
        }

        protected double HämtaViktKalv()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0 &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (double.Parse(a.Element("vikt").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaÅlderHanar()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (double.Parse(a.Element("ålder").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaÅlderHonor()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hona" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (double.Parse(a.Element("ålder").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaTaggar()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (string)a.Element("kön") == "Hane" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (double.Parse(a.Element("taggar").Value))).DefaultIfEmpty().Average();
            return Convert.ToInt32(xmlValue);
        }

       protected double HämtaSkjutnaHanar()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hane" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (a.Element("Hane"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaSkjutnaHonor()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") > 0 && (string)a.Element("kön") == "Hona" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
                            select (a.Element("Hona"))).Count();
            return Convert.ToInt32(xmlValue);
        }

        protected double HämtaSkjutnaHanKalvar()
        {
            DateTime startDatum = new DateTime(Int32.Parse(väljår.Text), 1, 1);
            DateTime slutDatum = new DateTime(Int32.Parse(väljår.Text), 12, 31);
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from a in xmlDoc.Descendants("avskutning")
                            where (int)a.Element("ålder") == 0 && (string)a.Element("kön") == "Hane" &&
                                  (DateTime)a.Element("datum") >= startDatum && (DateTime)a.Element("datum") <= slutDatum
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