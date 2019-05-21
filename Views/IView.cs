using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    interface IView
    {
        string getTitle { get; }
        QuizType getType { get; }
        string SetText { set; }
        event Action btClicked;
        event Action addQuestion;
        event Action removeQuestion;
    }
}
