using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_student_changemima : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        stuNum.Text = Session["user"].ToString();
        /*SqlCommand cmd = new SqlCommand("select * from studentInfo where 学号=@stuNum", conn);
        cmd.Parameters.AddWithValue("@stuNum", Session["user"].ToString());
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            stuNum.Text = dr[1].ToString();
            name.Text = dr[2].ToString();
            sex.Text = dr[3].ToString();
            xueyuan.Text = dr[4].ToString();
            stuclass.Text = dr[5].ToString();
        }
        dr.Close();
        conn.Close();*/
       
    }
    protected void submit_Click(object sender, EventArgs e)
    {


        SqlCommand upd = new SqlCommand("update studentInfo set 姓名 = @name ,性别 = @sex,学院 = @xueyuan,班级 = @stuclass where 学号 = @stuNum",conn);
            upd.Parameters.AddWithValue("@name", name.Text.ToString().Trim());
            upd.Parameters.AddWithValue("@stuNum",Session["user"].ToString());
            upd.Parameters.AddWithValue("@sex", sex.Text.ToString().Trim());
            upd.Parameters.AddWithValue("@xueyuan", xueyuan.Text.ToString().Trim());
            upd.Parameters.AddWithValue("@stuclass", stuclass.Text.ToString().Trim());
            conn.Open();
            int m = Convert.ToInt32(upd.ExecuteNonQuery());
            conn.Close();
            if (m == 1)
            {
                Response.Redirect("./myinfo.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('修改失败，请重试');</script>");

       
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        name.Text = "";
        sex.Text = "";
        xueyuan.Text = "";
        stuclass.Text = "";
    }
}