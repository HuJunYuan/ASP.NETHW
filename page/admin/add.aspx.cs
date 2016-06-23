using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_add : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = name.Text.ToString().Trim();
        string b = stuNum.Text.ToString().Trim();
        string c = sex.Text.ToString().Trim();
        string d = xueyuan.Text.ToString().Trim();
        string f = stuclass.Text.ToString().Trim();
        string l = math.Text.ToString().Trim();
        string k = Clan.Text.ToString().Trim();

        SqlCommand sel = new SqlCommand();
        sel.CommandText = "select count(*) from studentInfo where 学号= @stuNum";
        sel.Parameters.AddWithValue("@stuNum", b);
        sel.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(sel.ExecuteScalar());
        conn.Close();
        if (i == 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into studentInfo(学号,姓名,性别,学院,班级,数学,C语言) values( @stuNum,@name,@sex,@xueyuan,@stuclass,@math,@Clan)";
            cmd.Parameters.AddWithValue("@name", a);
            cmd.Parameters.AddWithValue("@stuNum", b);
            cmd.Parameters.AddWithValue("@sex", c);
            cmd.Parameters.AddWithValue("@xueyuan", d);
            cmd.Parameters.AddWithValue("@stuclass", f);
            cmd.Parameters.AddWithValue("@math", l);
            cmd.Parameters.AddWithValue("@Clan", k);
            
            cmd.Connection = conn;
            conn.Open();
            int m = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                Response.Redirect("./add.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，请重试');</script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，已存在该用户');</script>");
           
        }

    }
}