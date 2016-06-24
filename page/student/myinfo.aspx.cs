using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_student_myinfo : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from studentInfo where 学号=@stuNum", conn);
        int time = DateTime.Now.Hour;
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
        conn.Close();

    }
    protected void change_Click(object sender, EventArgs e)
    {
        Response.Redirect("./changemima.aspx");
    }
}