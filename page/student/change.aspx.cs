using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_student_change : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = oldpsw.Text.ToString().Trim();
        string b = newpsw.Text.ToString().Trim();
       
        SqlCommand sel = new SqlCommand("select count(*) from users where username= @name and password = @psw and iden = '学生'",conn);

        sel.Parameters.AddWithValue("@name", Session["user"].ToString());
        sel.Parameters.AddWithValue("@psw", a);
        sel.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(sel.ExecuteScalar());
        conn.Close();
        if (i == 1)
        {

            SqlCommand upd = new SqlCommand("update users set password = @psw where username = @name and iden='学生'", conn);
            upd.Parameters.AddWithValue("@psw", newpsw.Text.ToString().Trim());
            upd.Parameters.AddWithValue("@name", Session["user"].ToString());
            conn.Open();
            int m = Convert.ToInt32(upd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                Session.Clear();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('修改成功，请使用新密码重新登陆');location.href = '../login.aspx';</script>");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('修改失败，请重试');</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('修改失败，原密码错误');</script>");      
        }
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        oldpsw.Text = "";
        newpsw.Text = "";
    }
}