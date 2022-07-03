using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes.Note
{
    public class NoteHandler : Object, IOriginator
    {
        public NoteHandler() : base()
        {
        }

        private List<Note> _Notes = null;
        public List<Note> Notes
        {
            get
            {
                if (_Notes == null)
                {
                    _Notes = new List<Note>();
                }

                return (_Notes);
            }
        }

        public Memento CreateMemnto()
        {
            Memento memento = new Memento();

            memento.Notes = Notes;

            return (memento);
        }

        public void SetMemnto(Memento memnto)
        {
            foreach (Note note in memnto.Notes)
            {
                Notes.Add(note);
            }
        }

        public static void Save(List<Memento> memento)
        {
            FileStream file = new FileStream($"{Application.StartupPath}\\NotesData.Bin", System.IO.FileMode.Create, System.IO.FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(file, memento);

            file.Close();
            file.Dispose();
        }

        public static List<Memento> Load()
        {
            try
            {
                FileStream oFile = new FileStream($"{Application.StartupPath}\\NotesData.Bin", FileMode.Open, FileAccess.Read);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                List<Memento> oMementoes = (List<Memento>)binaryFormatter.Deserialize(oFile);

                oFile.Close();
                oFile.Dispose();
                return oMementoes;
            }
            catch
            {
                return null;
            }
        }

    }
}
