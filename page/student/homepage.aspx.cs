using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_student_homepage : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=StuInfo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("select 姓名 from studentInfo where 学号=@stuNum",conn);
        int time = DateTime.Now.Hour;
        cmd.Parameters.AddWithValue("@stuNum", Session["user"].ToString());
        conn.Open();
        string name = cmd.ExecuteScalar().ToString();
        conn.Close();
        string str = "";
        switch (time)
        {
            case 6:
            case 7:
            case 8: str = "早上好啊" + name + "同学，美美的吃顿早饭吧！"; break;
            case 9:
            case 10: str = "上午好" + name + "同学，努力学习的同时要注意休息哦！"; break;
            case 11:
            case 12: str = "中午好" + name + "同学，午饭吃的什么呢？"; break;
            case 13:
            case 14:
            case 15:
            case 16:
            case 17: str = "下午好" + name + "同学，适当的喝点茶可以让提神哦！"; break;
            case 18:
            case 19:
            case 20:
            case 21: str = "晚上好" + name + "同学，学习不是全部，干点你喜欢的事吧！"; break;
            case 22:
            case 23: str = "夜已经深了，" + name + "同学，赶紧洗洗睡了吧！"; break;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5: str = "你好啊" + name + "同学，现在是睡觉时间，快去睡觉！"; break;
        }
        info.Text = str;
    }
}