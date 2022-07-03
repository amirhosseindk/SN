using Sticky_Notes.Library;
using Sticky_Notes.Note;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes.Forms
{
    public partial class MenuForm : Sticky_Notes.Forms.BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if(DataContainer.NoteName != null)
            {
                foreach (string item in DataContainer.NoteName)
                {
                    NoteslistView.Items.Add(item);
                }
            }
        }

        private void NoteslistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (NoteslistView.SelectedItems[0] != null)
            {
                string firstSelectedItem = (string)NoteslistView.SelectedItems[0].Text;

                var ContentQuery = DataContainer.noteHandler.Notes
                    .Where(s => s.Name == firstSelectedItem)
                    .Select(s => s.Content)
                    .FirstOrDefault()
                    ;

                var ColorQuery = DataContainer.noteHandler.Notes
                    .Where(s => s.Name == firstSelectedItem)
                    .Select(s => s.Color)
                    .FirstOrDefault()
                    ;

                DataContainer.contentnote = ContentQuery;

                DataContainer.namenote = firstSelectedItem;

                DataContainer.colornote = ColorQuery;

                DataContainer.opened = true;

                NoteForm noteForm = new NoteForm();

                noteForm.Owner = this;

                noteForm.Show();


            }
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxtBox.Text != "")
            {
                for (int i = NoteslistView.Items.Count - 1; i >= 0; i--)
                {
                    var item = NoteslistView.Items[i];
                    if (item.Text.ToLower().Contains(SearchTxtBox.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        NoteslistView.Items.Remove(item);
                    }
                }
                if (NoteslistView.SelectedItems.Count == 1)
                {
                    NoteslistView.Focus();
                }
            }
            else
            {
                DataContainer.noteHandler.Notes.Clear();

                NoteslistView.Items.Clear();
                
                MenuForm_Load(sender, e);
            }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.Owner = this;
            noteForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NoteslistView.SelectedItems != null)
            {
                for (int i = 0; i < NoteslistView.SelectedItems.Count; i++)
                {
                    NoteslistView.Items.Remove(NoteslistView.SelectedItems[i]);
                    DataContainer.noteHandler.Notes.Remove(DataContainer.noteHandler.Notes[i]);
                }
                DataContainer.MyMementoes.Clear();
                DataContainer.MyMementoes.Add(DataContainer.noteHandler.CreateMemnto());
                NoteHandler.Save(DataContainer.MyMementoes);
            }
            //if (NoteslistView.SelectedItems[0] != null)
            //{
            //        string firstSelectedItem = (string)NoteslistView.SelectedItems[0].Text;

            //        var NoteQuery = noteHandler.Notes
            //            .Where(s => s.Name == firstSelectedItem)
            //            .Select(s => s)
            //            .FirstOrDefault()
            //            ;

            //            noteHandler.Notes
            //            .Remove(NoteQuery)
            //            ;

            //        MenuForm.MyMementoes.Add(MenuForm.noteHandler.CreateMemnto());

            //        Note.NoteHandler.Save(MenuForm.MyMementoes);

            //        NoteslistView.Items.Remove(NoteslistView.SelectedItems[0]);
            //}
        }
    }
}
