using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public interface IMultipleChoiceView
    {
        event Action addItem;
        
        MultipleChoiceItem MultipleChoiceItem { set; }
    }
}
