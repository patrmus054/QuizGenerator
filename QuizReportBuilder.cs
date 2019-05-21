using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class QuizReportBuilder : IQuizReportBuilder
    {
        private Quiz _quiz;
        private IEnumerable<Question> questions;
        public QuizReportBuilder(IEnumerable<Question> questions)
        {
            this.questions = questions;
            _quiz = new Quiz();
        }


        public Quiz GetRaport()
        {
            var quiz = _quiz;
            Clear();
            return quiz;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach(var obj in questions)
            {
                text.Append(obj);
            }
            text.Append(_quiz.Author).Append(_quiz.executionTime).Append(_quiz.score).Append(_quiz.type);
            return text.ToString();
        }

        IQuizReportBuilder IQuizReportBuilder.BuilderAuthor(string author)
        {
            _quiz.Author = author;
            return this;
        }

        IQuizReportBuilder IQuizReportBuilder.BuilderExecutionTime()
        {
            _quiz.executionTime = $"Now it's {DateTime.Now}";
            return this;
        }

        IQuizReportBuilder IQuizReportBuilder.BuilderScore(int score)
        {
            _quiz.score = score;
            return this;
        }

        IQuizReportBuilder IQuizReportBuilder.BuilerType(QuizType type)
        {
            _quiz.type = type;
            return this;
        }

        private void Clear() => _quiz = new Quiz();
    }
}
