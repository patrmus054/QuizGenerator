using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public interface IQuizReportBuilder
    {
        //void BuilerType();
        //void BuilderScore();
        //void BuilderAuthor();
        //void BuilderExecutionTime();

        IQuizReportBuilder BuilerType(QuizType type);
        IQuizReportBuilder BuilderScore(int score);
        IQuizReportBuilder BuilderAuthor(string str);
        IQuizReportBuilder BuilderExecutionTime();
        Quiz GetRaport();

    }
}
