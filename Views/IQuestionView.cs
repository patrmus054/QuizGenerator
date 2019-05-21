using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Views
{
    public interface IQuestionView
    {
        QuestionType GetQuestionType { get; }
        string Title { get; }
        string CorrectAnwser { get; }
    }
}
