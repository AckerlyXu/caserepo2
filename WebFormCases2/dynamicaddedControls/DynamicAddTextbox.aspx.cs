using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.dynamicaddedControls
{
    public partial class DynamicAddTextbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox uPassTextBox = new TextBox();
            uPassTextBox = new System.Web.UI.WebControls.TextBox();
            uPassTextBox.ID = "_Password";
            uPassTextBox.AutoPostBack = true;
          
        ///    uPassTextBox.TextMode = TextBoxMode.Password;
            uPassTextBox.Attributes.Add("autocomplete", "new-password");
            uPassTextBox.Style.Add("left", "0mm");
            uPassTextBox.Style.Add("top", "0mm");
            uPassTextBox.Style.Add("position", "relative");
          
            
            uPassTextBox.Style.Add("font-family", "monospace");
         
            uPassTextBox.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.Form.Controls.Add(uPassTextBox);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write((sender as TextBox).Text);
        }
    }
}