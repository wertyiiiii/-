using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [HttpPost]
        public Form1()
        {
            InitializeComponent();
        }
        const string token = "X5QWuJgj5cLI3yD6Oh6FlO5thD/MkD0tNHIpwWlICN61kGimQCOpgpMqd2s4JXjejQkRTeaO7w47PgnsRl+znCiFiyOTJIUi30jkh7sY4innfgYe3MgrDmMEH25IYvSKuiYcSuBd1tnurFMtMwQuJAdB04t89/1O/w1cDnyilFU=";

        private void button1_Click(object sender, EventArgs e)
        {
            var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
            ButtonsTemplateMsg.altText = "";
            ButtonsTemplateMsg.thumbnailImageUrl = new Uri("https://d2k0a7u1vq875o.cloudfront.net/data/Article/2223/Article_64a0db96b9a50d4670aeb00_638x478.jpg?v=201707100001");
            ButtonsTemplateMsg.text = "請問您要找的東西是?";
            ButtonsTemplateMsg.title = "貴賓您好〜"; 
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "衣服店", text = "衣服店" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "化妝品", text = "化妝品" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "美食", text = "美食" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "運動", text = "運動" });
            ButtonsTemplateMsg.actions = actions;
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            bot.PushMessage(AdminUserID, ButtonsTemplateMsg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string p=Requested.
            var ReceiveMessage = isRock.LineBot.Utility.Parsing(p);
            var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
            ButtonsTemplateMsg.altText = "";
            ButtonsTemplateMsg.thumbnailImageUrl = new Uri("https://d2k0a7u1vq875o.cloudfront.net/data/Article/2223/Article_64a0db96b9a50d4670aeb00_638x478.jpg?v=201707100001");
            ButtonsTemplateMsg.text = "請問您要找的東西是?";
            ButtonsTemplateMsg.title = "貴賓您好〜";
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "衣服店", text = "衣服店" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "化妝品", text = "化妝品" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "美食", text = "美食" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "運動", text = "運動" });
            ButtonsTemplateMsg.actions = actions;
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            bot.PushMessage(AdminUserID, ButtonsTemplateMsg);
        }
    }
}
