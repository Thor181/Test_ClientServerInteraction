using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_ClientServerInteraction.Models;

namespace Test_ClientServerInteraction.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public void SimpleGet()
        {
            Debug.WriteLine("Simple get");
        }

        [HttpGet]
        public void SimpleGetParam(string param1)
        {
            Debug.WriteLine($"Simple get. Param \"{param1}\"");
        }

        [HttpPost]
        public void SimplePost()
        {
            Debug.WriteLine("Simple post");
        }

        [HttpPost]
        public void SimplePostParam([FromBody] Data param)
        {
            Debug.WriteLine($"Simple post. Param \"{param.Body}\"");
        }

        [HttpPost]
        public void FormPost()
        {
            Debug.WriteLine($"Form post");
        }

        [HttpPost]
        public void FormPostParam(string param)
        {
            Debug.WriteLine($"Form post. Param \"{param}\"");
        }

        [HttpPost]
        public void FormPostParamAsObject(Data data)
        {
            Debug.WriteLine($"Form post. Param \"{data.Body}\"");
        }

    }

    public class Data
    {
        public string Body { get; set; }
    }
}
