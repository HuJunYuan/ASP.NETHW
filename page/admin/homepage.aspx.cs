using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_admin_homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int time = DateTime.Now.Hour;
        string str = "";
        switch (time)
        {
            case 6:
            case 7:
            case 8: str = "早上好" + Session["user"] + "，美美的吃顿早饭吧！"; break;
            case 9: 
            case 10: str = "上午好" + Session["user"] + "，努力工作的同时要注意休息哦！"; break;
            case 11:
            case 12: str = "中午好" + Session["user"] + "，午饭吃的什么呢？"; break;
            case 13:
            case 14:
            case 15:
            case 16:
            case 17: str = "下午好" + Session["user"] + "，适当的喝点茶可以让提神哦！"; break;
            case 18:
            case 19:
            case 20:
            case 21: str = "晚上好" + Session["user"] + "，工作不是全部，干点你喜欢的事吧！"; break;
            case 22:
            case 23: str = "夜已经深了，" + Session["user"] + "赶紧洗洗睡了吧！"; break;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5: str = "你好啊" + Session["user"] + "现在可是睡觉时间，快快去睡觉！"; break;
        }
        info.Text = str;
    }
}