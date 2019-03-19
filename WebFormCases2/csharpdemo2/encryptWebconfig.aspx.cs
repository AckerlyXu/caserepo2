using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpdemo2
{
    public partial class encryptWebconfig : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         Configuration configuration =    WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath+"/csharpdemo2/Web.config");
            
            AuthorizationSection section = (AuthorizationSection)configuration.GetSection("system.web/authorization");
            section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
            if (section.SectionInformation.IsProtected)
            {
                section.SectionInformation.UnprotectSection();
            }
            else
            {
                section.SectionInformation.ProtectSection("SampleProvider");
            }

            // Save changes to the Web.config file.
            configuration.Save();
        }
    }
}