using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticky_Notes.Note
{
    [Serializable]
    public class Memento : Object
    {
        public Memento() : base()
        {
        }

        public List<Note> Notes { get; set; }
    }
}
