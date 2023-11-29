using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;

namespace Project_MVC.Controllers
{
    public class ApiController : Controller
    {

        [HttpGet]
        [Route("Contact")]
        public List<Contact> Contact()
        {

            Contact contact = new Contact();

            return new List<Contact>
            {
                new Contact
                {
                    CName = "楊書瑋",
                    EName = "Craig Yang",
                    Email = "geneXXXX@gmail.com",
                    Tag = "偽工程師",
                    Phone = "0970-828-XXX",
                    Intro = "出生於1989年4月5日，居住於新北市。興趣是健身和跑步，目標是可以完成一次全馬比賽。\r\n從大學畢業之後，雖說有學習金融和行銷的主修，但是我對新的事物仍保有學習的態度。有學習過程式語言和Podcast的企畫和錄製，曾有主持個人頻道的經驗。雖然說時間和學習能力是有限的，但是要保持終身學習的心，才可以為職涯產生新的思維和想法。\r\n",
                    Character_heading1 = "熱枕工作點滿",
                    Character_intro1 = "曾經被同事說，負責到離職最後一刻，甚至離職當天跑完流程還加班。對於工作的態度負責且秉持做一天和尚敲一天鐘的精神。",
                    Character_heading2 = "求知學習態度",
                    Character_intro2 = "學海無涯，現今的社會變化這麼大，需要不斷充實自己才不會被社會淘汰。",
                    Character_heading3 = "培養正向興趣",
                    Character_intro3 = "喜歡跑步、健身和爬山，培養戶外運動和興趣。讓自己除了工作之外，也達到工作和生活平衡。",
                    Job_heading1 = "雄獅旅行社股份有限公司 營運企劃主任",
                    Job_start1 = new DateTime(2022,10,17),
                    Job_end1 = new DateTime(2023,03,31),
                    Job_intro1 = "【工作內容】系統需求確認、外部專案溝通、API規格溝通、系統測試、查詢訂單log\r\n【行銷相關經驗】活動專案產品整合、GA數據觀察\r\n",


                },

            };
        }

        // GET: Api
        public ActionResult Index()
        {
            return View();
        }
    }
}