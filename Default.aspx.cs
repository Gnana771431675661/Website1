using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataTable dt = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (ViewState["Details"] == null)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                ViewState["Details"] = dataTable;
            }
        }
    }
    protected void btnAddClick(object sender, EventArgs e)
    {
        string str = txtname.Text.Trim();
        dt = (DataTable)ViewState["Details"];
        dt.Rows.Add(str);
        ViewState["Details"] = dt;
        lstdetails.DataSource = dt;
        lstdetails.DataTextField = "Name";
        lstdetails.DataValueField = "Name";
        lstdetails.DataBind();
        txtname.Text = "";
    }
}
