using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_student_stuMasterPage : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            if (Session["user"] == null)
                Response.Redirect("../login.aspx");
    }
}
