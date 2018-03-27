using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpPost]
        public IHttpActionResult POST()

        {

            string ChannelAccessToken = "X5QWuJgj5cLI3yD6Oh6FlO5thD / MkD0tNHIpwWlICN61kGimQCOpgpMqd2s4JXjejQkRTeaO7w47PgnsRl + znCiFiyOTJIUi30jkh7sY4innfgYe3MgrDmMEH25IYvSKuiYcSuBd1tnurFMtMwQuJAdB04t89 / 1O / w1cDnyilFU = ";

            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                string Message = ReceivedMessage.events[0].message.text;
                //--------//測試用 (有反應)

                //-----------(打找東西 以下無反應)
                if (ReceivedMessage.events[0].message.text == "找東西")
                {

                    //建立一個Buttons Template Message物件
                    var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
                    //設定thumbnailImageUrl
                    ButtonsTemplateMsg.altText = "無法顯示時的替代文字";
                    ButtonsTemplateMsg.thumbnailImageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201709/14-143030-1cd8cf1e-8f77-4652-9afa-605d27f20933.png");
                    ButtonsTemplateMsg.text = "請問您要找的東西是?";
                    ButtonsTemplateMsg.title = "貴賓您好〜"; //標題
                                                        //建立actions
                    var actions = new List<isRock.LineBot.TemplateActionBase>();
                    actions.Add(new isRock.LineBot.MessageAction() { label = "衣服店", text = "衣服店" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "化妝品",text = "化妝品" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "美食", text = "美食" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "運動", text = "運動" });
                    //將建立好的actions選項加入
                    ButtonsTemplateMsg.actions = actions;
                    //建立bot instance
                    isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);
                    //send ButtonsTemplateMsg
                    isRock.LineBot.Utility.ReplyTemplateMessage(ReceivedMessage.events[0].replyToken, ButtonsTemplateMsg, ChannelAccessToken);
                }
                else if(ReceivedMessage.events[0].message.text == "查詢")
                {
                    //建立一個Buttons Template Message物件
                    var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
                    //設定thumbnailImageUrl
                    ButtonsTemplateMsg.altText = "無法顯示時的替代文字";
                    ButtonsTemplateMsg.thumbnailImageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201709/14-143030-1cd8cf1e-8f77-4652-9afa-605d27f20933.png");
                    ButtonsTemplateMsg.text = "請問您要找的東西是?";
                    ButtonsTemplateMsg.title = "貴賓您好〜"; //標題
                                                        //建立actions
                    var actions = new List<isRock.LineBot.TemplateActionBase>();
                    actions.Add(new isRock.LineBot.MessageAction() { label = "衣服店", text = "衣服店" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "化妝品", text = "化妝品" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "美食", text = "美食" });
                    actions.Add(new isRock.LineBot.MessageAction() { label = "運動", text = "運動" });
                    //將建立好的actions選項加入
                    ButtonsTemplateMsg.actions = actions;
                    //建立bot instance
                    isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);
                    //send ButtonsTemplateMsg
                    isRock.LineBot.Utility.ReplyTemplateMessage(ReceivedMessage.events[0].replyToken, ButtonsTemplateMsg, ChannelAccessToken);
                }

                else
                {
                    Message = "你說了:" + ReceivedMessage.events[0].message.text;
                    isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                //請自行處理Exception
                return Ok();
            }
        }
    }
}
