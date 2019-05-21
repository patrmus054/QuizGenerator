using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public enum QuizType { MARKED, SURVEY, POLL}
    public class Quiz
    {
        public string Author { get; set; }
        public QuizType type { set; get; }
        public float score { set; get; }
        public string executionTime { set; get; }

        public override string ToString()
        {
            return $"{Author}, {type}, {score}, {executionTime}";
        }
    }
}
