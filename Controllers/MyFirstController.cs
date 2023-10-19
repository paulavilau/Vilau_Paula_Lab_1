using Microsoft.AspNetCore.Mvc;

namespace Vilau_Paula_Lab_1.Controllers
{
    public class MyFirstController : Controller
    {
        public string Index()
        {
            return "Welcome";
        }

        public string Hello()
        {
            return "Hello";
        }

        public string RandomMethod(string mesaj, int numar)
        {
            return $"Mesaj: {mesaj}, Numar: {numar}";
        }
    }
}
