using Microsoft.AspNetCore.Mvc;
using News.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News.Controllers
{
    public class ChatController : Controller
    {

        public List<ChatMessage> Messages()
        {
            var db = new DbCont();
            return db.Chat.OrderByDescending(x => x.Date).ToList();
        }

        public void AddMessage(string message)
        {
            var db = new DbCont();
            db.Chat.Add(new ChatMessage { Date = DateTime.Now, Message = message });
            // db.SaveChanges();
        }
    }
}
