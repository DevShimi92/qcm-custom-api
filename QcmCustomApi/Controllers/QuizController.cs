using Microsoft.AspNetCore.Mvc;
using QcmCustomApi.Interfaces.Services;

namespace QcmCustomApi.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizService quizService;

        public QuizController(IQuizService _quizService)
        {
            this.quizService = _quizService;
        }
        [HttpPost]
        public string Create()
        {
            return "Create";
        }
        [HttpGet]
        public string GetAll()
        {
            return "GetAll";
        }
        [HttpGet]
        public string GetOne()
        {
            return "GetOne";
        }
        [HttpPut]
        public string Update()
        {
            return "Update";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Delete";
        }
    }
}
