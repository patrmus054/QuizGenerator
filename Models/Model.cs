using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Model
    {
        public Quiz getRaport(List<Question> questions, QuizType type, string author, int score)
        {
            var builder = new QuizReportBuilder(questions);
            var direction = new QuizReportDirector(builder);
            direction.buildQuizReport(type,author,score);
            var report = builder.GetRaport();
            return report;
        }
    }
}
