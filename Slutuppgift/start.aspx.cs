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
          snittvikthanar.Text = HämtaViktHane().ToString();
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
    }
}