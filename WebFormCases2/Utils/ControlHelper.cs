using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace MyWebFormCases.Utils
{
    public static class ControlHelper
    {

        public static Control FindControlRecursive(this Control control, string id)
        {
            if (control.ID == id)
                return control;

            foreach (Control ctl in control.Controls)
            {
                if (ctl.ID == id)
                    return ctl;
                Control child = FindControlRecursive(ctl, id);
                if (child != null)
                    return child;
            }
            return null;
        }
    }
}