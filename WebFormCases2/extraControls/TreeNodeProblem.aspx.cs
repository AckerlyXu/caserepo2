using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.extraControls
{
    public partial class TreeNodeProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Accname"));
            dataTable.Columns.Add(new DataColumn("Accid"));
            dataTable.Columns.Add(new DataColumn("ParAcc"));
            dataTable.Rows.Add("namecy", "1234", "Minus");
            dataTable.Rows.Add("kerry", "4567", "info");
            TreeNode rootNode = new TreeNode("BudgetAccounts");
            TreeView1.Nodes.Add(rootNode);

            foreach (DataRow item in dataTable.Rows)
            {
                TreeNode nod = new TreeNode(item["Accname"].ToString());
                nod.ChildNodes.Add(new TreeNode(item["Accid"].ToString()));
                nod.ChildNodes.Add(new TreeNode(item["ParAcc"].ToString()));
                rootNode.ChildNodes.Add(nod);

            }
           
            
            rootNode.CollapseAll();
        }
    }
}