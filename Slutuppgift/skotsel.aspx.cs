using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Slutuppgift
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }

        protected void TreeView1_SelectedNodeChanged1(object sender, EventArgs e)
        {

        }

        protected void comfirm_Click(object sender, EventArgs e)
        {
            XElement xelement = XElement.Load(Server.MapPath("Jaktlag.xml"));         
                xelement.Add
               (new XElement("jaktlag", jaktlag.Text),
                new XElement("namn", shootername.Text),
                new XElement("datum", date.Text),
                new XElement("kön", kön.Text),
                new XElement("vikt", vikt.Text),
                new XElement("taggar", taggar.Text),
                new XElement("ålder", ålder.Text)
                );
                xelement.Save((Server.MapPath("Jaktlag.xml")));   
        }
    }
}