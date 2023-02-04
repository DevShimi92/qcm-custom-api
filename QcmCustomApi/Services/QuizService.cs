using QcmCustomApi.Interfaces.Repositories;
using QcmCustomApi.Interfaces.Services;

namespace QcmCustomApi.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository quizRepository;

        public QuizService(IQuizRepository _quizRepository)
        {
            quizRepository = _quizRepository;
        }
    }
}
