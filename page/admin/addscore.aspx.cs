using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_addscore : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = score.Text.ToString().Trim();
        string b = stuNum.Text.ToString().Trim();

        SqlCommand sel = new SqlCommand();
        sel.CommandText = "select count(*) from studentInfo where 学号= @stuNum";
        sel.Parameters.AddWithValue("@stuNum", b);
        sel.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(sel.ExecuteScalar());
        conn.Close();
        if (i == 1)
        {
            SqlCommand cmd = new SqlCommand("insert into score(学号,课程编号,成绩) values( @stuNum,@num,@score)",conn);
            cmd.Parameters.AddWithValue("@stuNum", b);
            cmd.Parameters.AddWithValue("@score", a);
            cmd.Parameters.AddWithValue("@num", which.SelectedItem.Value.ToString());
            conn.Open();
            int m = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加成功');</script>");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，请重试');</script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败，不存在该学生');</script>");

        }
    }
}