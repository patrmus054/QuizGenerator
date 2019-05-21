using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public enum QuestionType { TEXT, MULTIPLECHOICE, DESCRIPTION, CHECKBOX, NUMBERRANGE }
    abstract public class Question
    {
        
        private QuestionType type { get; set; }
        private string context { get; set; }
        private string correctAnwser { get; set; }

        public Question(QuestionType type, string context)
        {
            this.type = type;
            this.context = context;
        }
        public string getCorrectAnwser() { return correctAnwser; }
        public void setCorrectAnwser(string value) { correctAnwser = value; }

        public override string ToString()
        {
            return $"QuestionType: {type} context: {context} correctAnwser{correctAnwser}";
        }
    }
}
