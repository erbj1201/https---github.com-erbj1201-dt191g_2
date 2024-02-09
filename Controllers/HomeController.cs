using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        //Route index
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        //Route index
        [Route("/")]
        //Post
        [HttpPost]
        public IActionResult Index(MessageModel model)
        {
            if (ModelState.IsValid)
            { // Read Json-file
                string jsonMessage = System.IO.File.ReadAllText("messages.json");
                // Convert from Json
                var messages = JsonSerializer.Deserialize<List<MessageModel>>(jsonMessage);

                // Add new message, if not null
                if (messages != null)
                {
                    messages.Add(model);
                    // Serialize json
                    jsonMessage = JsonSerializer.Serialize(messages);
                    // Write to json-file
                    System.IO.File.WriteAllText("messages.json", jsonMessage); // Fixed typo in filename
                }
                //Clear form
                ModelState.Clear();
            }
            return View();
        }

        //Route projekt
        [Route("/projekt")]
        public IActionResult Projects()
        {
            return View();
        }

        //Route ubildning
        [Route("/utbildning")]
        public IActionResult Education()
        { // Read Json-file
            string jsonCourses = System.IO.File.ReadAllText("webbutvecklingcourses.json");
            // Convert from Json
            var courses = JsonSerializer.Deserialize<List<CourseModel>>(jsonCourses);
            //Send to view
            return View(courses);
        }

        //Route kontakt
        [Route("/kontakt")]
        public IActionResult Contact()
        { //ViewBag message
            ViewBag.Message = "Vad kan jag hjälpa dig med?";
            //ViewData message
            ViewData["ContactMe"] = "Tveka inte att höra av dig!";
            return View();
        }
    }
}
