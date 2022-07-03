using Sticky_Notes.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sticky_Notes.Library
{
    public static class DataContainer : object
    {
        static DataContainer()
        {
        }

        private static NoteHandler _noteHandler = null;
        public static NoteHandler noteHandler
        {
            get
            {
                if (_noteHandler == null)
                {
                    _noteHandler = new NoteHandler();
                }

                return (_noteHandler);
            }
        }

        private static List<Memento> _myMementoes;
        public static List<Memento> MyMementoes
        {
            get
            {
                if (_myMementoes == null)
                {
                    _myMementoes = new List<Memento>();
                }

                return (_myMementoes);
            }
        }

        private static List<string> _notename = null;
        public static List<string> NoteName
        {
            get
            {
                if (_notename == null)
                {
                    _notename = new List<string>();
                }
                return (_notename);
            }
        }

        public static byte[] contentnote { get; set; }

        public static string namenote { get; set; }

        public static Color? colornote { get; set; }

        public static DateTime? DTnote { get; set; }

        public static bool opened { get; set; }

    }
}
