using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Views;

namespace Quiz
{
    public partial class MultipleChoice : UserControl, IQuestionView
    {
        public MultipleChoice()
        {
            InitializeComponent();
        }

        public MultipleChoiceItem MultipleChoiceItem
        {
            set
            {
                flowLayoutPanel1.Controls.Add(value);
            }
        }

        public QuestionType GetQuestionType => QuestionType.MULTIPLECHOICE;

        public string Title => tbQuestionText.Text;

        public string CorrectAnwser => throw new NotImplementedException();

        public event Action addItem;

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            addItem?.Invoke();
            flowLayoutPanel1.Controls.Add(new MultipleChoiceItem());
        }
    }
}
