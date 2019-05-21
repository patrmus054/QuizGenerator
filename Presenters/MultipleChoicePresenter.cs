using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class MultipleChoicePresenter
    {
        IMultipleChoiceView view;
        Model model;
        

        MultipleChoicePresenter(IMultipleChoiceView view, Model model)
        {
            this.view = view;
            this.model = model;
            //this.view.addItem += addNewItem;
            
        }


    }
}
