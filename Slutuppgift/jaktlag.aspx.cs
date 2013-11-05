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

        /*     
          protected List<string> HämtaArtister()
          
          {
           XElement jakt= XElement.Load(path);

           var albumSamling = (from a in jakt.Elements("jaktlag").Elements("jaktlagsnamn")
                                
                               select (string)a).Distinct().ToList<string>();
           return albumSamling;
       }*/

    }
}