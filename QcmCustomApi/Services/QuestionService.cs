using QcmCustomApi.Interfaces.Repositories;
using QcmCustomApi.Interfaces.Services;

namespace QcmCustomApi.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;

        public QuestionService(IQuestionRepository _questionRepository)
        {
            questionRepository = _questionRepository;
        }

    }
}
