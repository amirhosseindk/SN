using Sticky_Notes.Library;
using Sticky_Notes.Note;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes.Forms
{
    public partial class NoteForm : Sticky_Notes.Forms.BaseForm
    {
        public NoteForm()
        {
            InitializeComponent();
        }


        private Note.Note note = new Note.Note();

        //private void NewNoteButton_Click(object sender, EventArgs e)
        //{
        //    NoteForm noteForm = new NoteForm();
        //    //noteForm.Owner = MenuForm;
        //    noteForm.Show();
        //}

        private void NoteRichTextBox_TextChanged(object sender, EventArgs e)
        {
            note.Content = System.Text.Encoding.UTF8.GetBytes(NoteRichTextBox.Rtf);
        }


        private void NoteRichTextBox_BackColorChanged(object sender, EventArgs e)
        {
            note.Color = NoteRichTextBox.BackColor;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(NoteSub.Text == string.Empty)
            {
                MessageBox.Show("Note Subject Cant Be Null");
                return;
            }

            if (NoteRichTextBox.Text == string.Empty)
            {
                MessageBox.Show("Note Text Cant Be Null");
                return;
            }

            var NoteQuery = DataContainer.noteHandler.Notes
                .Where(s => s.Name == DataContainer.namenote)
                .Select(s => s)
                .FirstOrDefault()
                ;

            int j=-1;

            if(NoteQuery!=null && DataContainer.opened)
            {
                for (int i = 0; i < DataContainer.noteHandler.Notes.Count; i++)
                {
                    if (DataContainer.noteHandler.Notes[i].Name == DataContainer.namenote)
                    {
                        j = i;
                    }
                }

                DataContainer.noteHandler.Notes[j] = note;

                Note.NoteHandler.Save(DataContainer.MyMementoes);

                (this.Owner as MenuForm).NoteslistView.Items.RemoveAt(j);

                (this.Owner as MenuForm).NoteslistView.Items.Add(note.Name);

                DataContainer.opened = false;

                DataContainer.namenote = null;
            }
            else
            {
                DataContainer.noteHandler.Notes.Add(note);

                DataContainer.MyMementoes.Add(DataContainer.noteHandler.CreateMemnto());

                Note.NoteHandler.Save(DataContainer.MyMementoes);

                (this.Owner as MenuForm).NoteslistView.Items.Add(note.Name);
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            if(DataContainer.namenote != null)
            {
                NoteRichTextBox.Rtf = System.Text.Encoding.UTF8.GetString(DataContainer.contentnote);
                NoteSub.Text = DataContainer.namenote;
                NoteRichTextBox.BackColor = (Color)DataContainer.colornote;
                NoteSub.BackColor = (Color)DataContainer.colornote;

                DataContainer.contentnote = null;

                DataContainer.colornote = null;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            DialogResult result = cd.ShowDialog();

            if (result == DialogResult.OK)
            {
                NoteRichTextBox.BackColor = cd.Color;
                NoteSub.BackColor = cd.Color;
            }
        }

        private void NoteSub_TextChanged_1(object sender, EventArgs e)
        {
            note.Name = NoteSub.Text;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                NoteRichTextBox.Font = fd.Font;
            }
        }

        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteRichTextBox.Text = NoteRichTextBox.Text.ToLower();
        }

        private void uppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteRichTextBox.Text = NoteRichTextBox.Text.ToUpper();
        }

        private void sentenceCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lowerCase = NoteRichTextBox.Text.ToLower();
            var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
            NoteRichTextBox.Text = r.Replace(lowerCase, s => s.Value.ToUpper());
        }

        private void capitalizeEachWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            NoteRichTextBox.Text = myTI.ToTitleCase(NoteRichTextBox.Text);
        }

        private void toggleCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            foreach (char c in NoteRichTextBox.Text)
            {
                if (char.IsLower(c))
                    result += Char.ToUpper(c);
                else
                    result += Char.ToLower(c);
            }
            NoteRichTextBox.Text = result;
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Clipboard.SetImage(Image.FromFile(ofd.FileName));
                    NoteRichTextBox.Paste();
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            NoteRichTextBox.Font = new Font(NoteRichTextBox.Font, FontStyle.Bold);
        }
    }
}
