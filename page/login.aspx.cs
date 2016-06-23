using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_login : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        string a = name.Text.ToString().Trim();
        string b = password.Text.ToString().Trim();
        string c = who.SelectedValue;
        switch (c)
        {
            case "学生": cmd.CommandText = "select count(*) from user where 账号= @name and 密码 = @psw and 身份='学生'"; break;
            case "管理员": cmd.CommandText = "select count(*) from admin where username= @name and password = @psw "; break;
            case "家长": cmd.CommandText = "select count(*) from user where 账号= @name and 密码 = @psw and 身份='家长'"; break;
        }

        
       
        cmd.Parameters.AddWithValue("@name", a);
        cmd.Parameters.AddWithValue("@psw", b);
        cmd.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i == 1)
        {
            Session["user"] = a;
            Response.Redirect("./admin/homepage.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('登录失败，账号或密码错误');</script>");
            password.Text = "";
        }
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        name.Text = "";
        password.Text = "";
    }
}