﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;

namespace Project_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Skills> skills = new List<Skills>
            {

                new Skills {Skill = "C#", ImageUrl ="csharp.png", SkillDescription="C#（讀作 C Sharp）是一種由微軟公司開發的多範式、現代化的編程語言。它最初於2000年發布，被設計為一種用於構建Windows應用程序的語言。C#現在是.NET框架的一部分，支持跨平台開發，可用於構建各種類型的應用程序，包括桌面應用程序、Web應用程序、移動應用程序、雲服務等。C#是一種強類型、面向對象的語言，借鑒了C和C++的語法結構，同時還引入了一些現代編程語言的特性。它支持封裝、繼承和多態等面向對象編程概念，同時也有一系列的現代特性，如委托、Lambda表達式、LINQ（Language Integrated Query）等。\r\n\r\nC#語言廣泛用於開發各種應用程序，特別是在Microsoft生態系統中，包括使用.NET Core和.NET Framework。它是一種流行的編程語言之一，被廣泛用於企業級應用、遊戲開發、Web開發等領域。"},
                new Skills {Skill = "JavaScript", ImageUrl ="javascript.png", SkillDescription="JavaScript是一種高階、解釋型的程式語言，主要用於在網頁上添加互動性和動態內容。它是一種腳本語言，最初由Netscape公司於1995年推出，用於增強靜態HTML網頁的功能。如今，JavaScript已經成為Web開發中不可或缺的一部分，被廣泛應用於各種前端和後端開發場景。JavaScript主要用於處理客戶端的互動邏輯，包括使用者與網頁的互動、動態內容的更新以及回應使用者事件等。它是一種基於原型、事件驅動的語言，具有異步編程的能力，可以在不重新加載整個網頁的情況下更新部分網頁內容。\r\n\r\n除了前端開發，JavaScript也在後端開發中得到了廣泛應用，例如通過Node.js平台。它支持多種編程範式，包括面向對象編程（OOP）和函數式編程（FP），使得開發者能夠根據項目需求選擇合適的編程風格。\r\n\r\n總體而言，JavaScript是一種具有靈活性和廣泛應用領域的腳本語言，是構建現代Web應用的重要組成部分。"},
                new Skills {Skill = "html", ImageUrl ="html.png", SkillDescription=""},
                new Skills {Skill = "CSS", ImageUrl ="css.png", SkillDescription=""},
                new Skills {Skill = "Microsoft SQL", ImageUrl ="sql.png", SkillDescription="Microsoft SQL（Structured Query Language）是由Microsoft開發的一组關係型資料庫管理系统（RDBMS）產品。這組產品包括 Microsoft SQL Server 和 Azure SQL Database。Microsoft SQL Server： 這是Microsoft的關係型資料庫管理系统，用於儲存和檢索數據。SQL Server支持T-SQL（Transact-SQL）。這是一種SQL的發展，支持中間過程編譯和實務處理。SQL Server廣泛用於企業級應用程序和數據中心，提供強大效能、可靠性和安全性。"},
                new Skills {Skill = "jQuery", ImageUrl ="jquery.png", SkillDescription=""},
                new Skills {Skill = "Microsoft Azure", ImageUrl ="azure.png", SkillDescription=""},
                new Skills {Skill = "Ajax", ImageUrl ="ajax.jpg", SkillDescription=""},
                new Skills {Skill = "Power BI", ImageUrl ="powerbi.png", SkillDescription=""},
                new Skills {Skill = "GitHub", ImageUrl ="github.png", SkillDescription=""},

            };

            return View(skills);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            List<Contact> contacts = new List<Contact>
            {
                new Contact
                {
                    CName = "楊書瑋",
                    EName = "Craig Yang",
                    Email = "geneXXXX@gmail.com",
                    Tag = "偽工程師 | 百岳闖關者 | 2023半馬完成",
                    Phone = "0970-828-XXX",
                    Intro = "出生於1989年4月5日，居住於新北市。興趣是健身和跑步，目標是可以完成一次全馬比賽。\r\n從大學畢業之後，雖說有學習金融和行銷的主修，但是我對新的事物仍保有學習的態度。有學習過程式語言和Podcast的企畫和錄製，曾有主持個人頻道的經驗。雖然說時間和學習能力是有限的，但是要保持終身學習的心，才可以為職涯產生新的思維和想法。\r\n",
                    Character_heading1 = "熱枕工作點滿",
                    Character_intro1 = "曾經被同事說，負責到離職最後一刻，甚至離職當天跑完流程還加班。對於工作的態度負責且秉持做一天和尚敲一天鐘的精神。",
                    Character_heading2 = "求知學習態度",
                    Character_intro2 = "學海無涯，現今的社會變化這麼大，需要不斷充實自己才不會被社會淘汰。",
                    Character_heading3 = "培養正向興趣",
                    Character_intro3 = "喜歡跑步、健身和爬山，培養戶外運動和興趣。讓自己除了工作之外，也達到工作和生活平衡。",
                    Job_heading1 = "雄獅旅行社股份有限公司 營運企劃主任",
                    Job_start1 = new DateTime(2022, 10, 17),
                    Job_end1 = new DateTime(2023, 03, 31),
                    Job_intro1 = "【工作內容】系統需求確認、外部專案溝通、API規格溝通、系統測試、查詢訂單log\r\n【行銷相關經驗】活動專案產品整合、GA數據觀察\r\n",
                    Job_heading2 = "軒饌廚坊股份有限公司 品牌企劃主任",
                    Job_start2 = new DateTime(2022, 02, 21),
                    Job_end2 = new DateTime(2022, 08, 31),
                    Job_intro2 = "【工作內容】市場需求調查、專案管理、電商平台商品上架和訂單處理(Shopline、MOMO、PChome)、商品設計、開發供應商、品牌規劃、商品拍攝、外送平台操作(Ubereats、Foodpanda)\r\n【行銷相關經驗】協助新聞稿撰寫、行銷文宣品設計",
                    Job_heading3 = "易遊網旅行社 國內旅遊產品企劃/產品經理",
                    Job_start3 = new DateTime(2020, 06, 01),
                    Job_end3 = new DateTime(2022, 02, 18),
                    Job_intro3 = "【工作內容】產品規劃、行程規畫、預算規劃、毛利預估和數字管理、數位行銷廣告規劃\r\n【行銷相關經驗】記者會協助籌劃、協助新聞稿撰寫、行銷活動企劃、行銷企劃案撰寫 協助行銷版面設計、GA數據觀察\r\n"
                }

            };
            return View(contacts);
        }

        public ActionResult Contact()
        {
            ViewData["104Link"] = "https://pda.104.com.tw/profile/share/i7aZ4emdqeuxODygCXoh5SRfiMBPBViF";
            

            return View();
        }
    }
}