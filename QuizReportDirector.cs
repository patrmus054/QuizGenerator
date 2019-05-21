using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizReportDirector
    {
        private readonly IQuizReportBuilder _quizReportBuilder;

        public QuizReportDirector(IQuizReportBuilder quizReportBuilder)
        {
            _quizReportBuilder = quizReportBuilder;
        }
        public void buildQuizReport(QuizType type, string author, int score)
        {
            _quizReportBuilder.BuilerType(type).BuilderAuthor(author).BuilderExecutionTime().BuilderScore(score);
           
        }
    }
}
