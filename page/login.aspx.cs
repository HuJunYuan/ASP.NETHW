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
        string a = name.Text.ToString().Trim();
        string b = password.Text.ToString().Trim();
        string sel = who.SelectedItem.Value.ToString();
        SqlCommand cmd = new SqlCommand();
        switch (sel)
        {
            case "admin": cmd.CommandText = "select count(*) from admin where username= @name and password = @psw "; break;
            case "学生": cmd.CommandText = "select count(*) from users where username= @name and password = @psw and iden = @ide"; break;
            case "家长": cmd.CommandText = "select count(*) from users where username= @name and password = @psw and iden = @ide"; break;
        }
        cmd.Parameters.AddWithValue("@name", a);
        cmd.Parameters.AddWithValue("@psw", b);
        cmd.Parameters.AddWithValue("@ide", who.SelectedItem.Value.ToString());
        cmd.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i == 1)
        {
            Session["user"] = a;
            switch (sel)
            {
                case "admin": Response.Redirect("./admin/homepage.aspx"); break;
                case "学生": Response.Redirect("./student/homepage.aspx"); break;
                case "家长": Response.Redirect("./admin/homepage.aspx"); break;
            }
            
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