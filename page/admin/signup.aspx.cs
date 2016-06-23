using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_signup : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = username.Text.ToString().Trim();
        string b = password.Text.ToString().Trim();

        SqlCommand sel = new SqlCommand();
        sel.CommandText = "select count(*) from admin where username= @name";
        sel.Parameters.AddWithValue("@name", a);
        sel.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(sel.ExecuteScalar());
        conn.Close();
        if (i != 1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into admin values( @name,@psw)";
            cmd.Parameters.AddWithValue("@name", a);
            cmd.Parameters.AddWithValue("@psw", b);
            cmd.Connection = conn;
            conn.Open();
            int m = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                Response.Redirect("./signup.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，请重试');</script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，已存在该用户');</script>");
            password.Text = "";
        }
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
    }
}