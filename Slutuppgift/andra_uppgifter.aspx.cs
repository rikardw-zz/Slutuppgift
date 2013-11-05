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
              
        }

        static void changeInfo() {
         /*                         
            XElement personer = XElement.Load("personer.xml");

            XElement person = (from p in personer.Elements("person")
                               where p.Element("namn".Value == "Jörgen"
                               select p).First();
            person.Element("efternman").Value = "Olsson";
            personer.Save("personer.xml");  */
                                   
        }
    }
}