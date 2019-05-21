using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class FrameAddQuestionPresenter
    {
        IAddQuestionView view;
        Model model;
        public FrameAddQuestionPresenter(IAddQuestionView view, Model model)
        {
            this.view = view;
            this.model = model;
        }

       
        public void showDialog()
        {
            ((FormAddQuestion)view).ShowDialog();
            
        }
        public void hideDialog()
        {
            ((FormAddQuestion)view).Hide();
        }
    }
}
