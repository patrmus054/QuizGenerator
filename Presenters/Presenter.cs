using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Presenter
    {
        IView view;
        Model model;
        FrameAddQuestionPresenter addQuestionPresenter;
        List<Question> questions = new List<Question>();
        
        public Presenter(IView view, Model model)
        {
            addQuestionPresenter = new FrameAddQuestionPresenter(new FormAddQuestion(), model);
            this.view = view;
            this.model = model;
            this.view.btClicked += GetRaport;
            this.view.addQuestion += AddQuestion;
            //this.view.removeQuestion += ;
        }

        void GetRaport()
        {
           view.SetText = model.getRaport(questions,view.getType, "Ja", 100).ToString();
        }

        void AddQuestion()
        {
            addQuestionPresenter.showDialog();
        }
        
    }
}
