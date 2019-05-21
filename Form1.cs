using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            cbQuizType.DataSource = Enum.GetValues(typeof(QuizType));
        }

        public string SetText
        {
            set
            {
                richTextBox2.Text = value;
            }
        }

        public string getTitle => textboxTitle.Text;


        public QuizType getType
        {
            get => (QuizType)cbQuizType.SelectedItem;
        }


        public event Action btClicked;
        public event Action addQuestion;
        public event Action removeQuestion;

        private void btAdd_Click(object sender, EventArgs e)
        {
            addQuestion?.Invoke();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            btClicked?.Invoke();
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            removeQuestion?.Invoke();
        }
    }
}
