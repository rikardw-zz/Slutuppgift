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
          snittvikt.Text = HämtaInfo().ToString();
        }

        protected double HämtaInfo()
        {
            string strFileName = Server.MapPath("Jaktlag.xml");
            XDocument xmlDoc = XDocument.Load(strFileName);
            var xmlValue = (from prod in xmlDoc.Descendants("avskutning")
                            select
                            (
                                        int.Parse(prod.Element("vikt").Value)
                            )).Average();

            return xmlValue;
        }
    }
}