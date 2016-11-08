using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the drop down list when the page loads
                DropDownList ddl = (DropDownList)Page.FindControl("NumIngredientsDropDownList");
                for (int i = 1; i <= 15; i++)
                {
                    ListItem newListItem = new ListItem();
                    Label l = new Label();
                    newListItem.Value = i.ToString();

                    ddl.Items.Add(newListItem);
                }
            }
        }

        protected void NumIngredientsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel tempPanel = (Panel)Page.FindControl("IngredientsPanel");
            tempPanel.Controls.Clear();
            DropDownList ddl = (DropDownList)Page.FindControl("NumIngredientsDropDownList");
            TextBox tb;
            for (int i = 1; i <= int.Parse(ddl.SelectedValue); i++)
            {
                tb = new TextBox();
                tb.ID = "IngredientTextBox" + i;
                tempPanel.Controls.Add(tb);
            }
        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            Panel tempPanel = (Panel)Page.FindControl("IngredientsPanel");
            tempPanel.Controls.Clear();
            DropDownList ddl = (DropDownList)Page.FindControl("NumIngredientsDropDownList");
            TextBox tb;
            int selVal = int.Parse(ddl.SelectedValue);
            for (int i = 1; i <= selVal; i++)
            {
                tb = new TextBox();
                tb.ID = "IngredientTextBox" + i;
                tempPanel.Controls.Add(tb);
                tempPanel.Controls.Add(new LiteralControl("</br>"));
            }
        }
    }
}