using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticky_Notes.Note
{
    public interface IOriginator
    {
        Memento CreateMemnto();
        void SetMemnto(Memento memnto);
    }
}
