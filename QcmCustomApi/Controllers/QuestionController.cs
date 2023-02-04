using Microsoft.AspNetCore.Mvc;
using QcmCustomApi.Interfaces.Services;

namespace QcmCustomApi.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService QuestionService;

        public QuestionController(IQuestionService _QuestionService) 
        {
            this.QuestionService = _QuestionService;
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
