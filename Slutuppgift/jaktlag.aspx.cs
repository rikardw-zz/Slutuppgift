using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace Slutuppgift
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var v = from script in XElement.Load(Server.MapPath("Jaktlag.xml")).Elements("jaktlag")
                    select script;
            foreach (var item in v)
            {
                jaktlagInfo.Items.Add(item.Value + "");                
            }      
        }
    }
}