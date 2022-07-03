using Sticky_Notes.Library;
using Sticky_Notes.Note;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes.Forms
{
    public partial class SplashForm : BaseForm
    {
        Bitmap img = new Bitmap(Properties.Resources.Capture);
        public SplashForm()
        {
            InitializeComponent();

            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.WorkerSupportsCancellation = true;

            BitmapRegion.CreateControlRegion(this, img);
        }

        private Thread _LoadDataThread;

        private ThreadStart _LoadDataThreadStart;

        //delegate void LoadDataDelegate(bool blnExist);

        private void SplashForm_Load(object sender, EventArgs e)
        {
            _LoadDataThreadStart = new ThreadStart(ItemLoad);

            _LoadDataThread = new Thread(_LoadDataThreadStart);

            _LoadDataThread.Start();

            backgroundWorker.RunWorkerAsync();
        }
        //private static ListView _owner = null;
        //public static ListView Owener
        //{
        //    get
        //    {
        //        if (_owner == null)
        //        {
        //            _owner= new ListView();
        //        }

        //        return (_owner);
        //    }
        //}
        //private static ListView.ListViewItemCollection _item = null;
        //public static ListView.ListViewItemCollection Item
        //{
        //    get
        //    {
        //        if (_item == null)
        //        {
        //            _item = new ListView.ListViewItemCollection(Owener);
        //        }

        //        return (_item);
        //    }
        //}

        public void ItemLoad()
        {
            List<Memento> oMementoes = NoteHandler.Load();

            if (oMementoes != null)
            {
                foreach (Memento memento in oMementoes)
                {
                    DataContainer.noteHandler.SetMemnto(memnto: memento);

                    foreach (Note.Note notee in DataContainer.noteHandler.Notes)
                    {
                        if (notee.Name != string.Empty)
                        {
                            DataContainer.NoteName.Add(notee.Name);
                        }
                    }
                }
            }

            //EndItemLoad(false);
        }

        //private void EndItemLoad(bool blnVisible)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        LoadDataDelegate oCallBack =
        //            new LoadDataDelegate(EndItemLoad);

        //        Invoke(oCallBack, new object[]
        //        {
        //            blnVisible
        //        });
        //    }
        //    else
        //    {

        //    }
        //}

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker =
              sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                Thread.Sleep(1);

                // Report progress.
                backgroundWorker.ReportProgress(i);

                if (backgroundWorker.CancellationPending)
                {
                    // this is important as it set the cancelled property of RunWorkerCompletedEventArgs to true
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int index = e.ProgressPercentage;

            System.Threading.Thread.Sleep(70);

            myProgressBar.ForeColor =
                Color.FromArgb(index + 155, 2 * index, index);//(255, 0, 0);

            myProgressBar.Value = index;

            myProgressBar.Refresh();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {

            //Some Effect are :
            // CollapseInward_Effect = AW_ACTIVATE | AW_CENTER;
            //  FadeEffect = AW_ACTIVATE | AW_BLEND;
            //   BottomToTop = AW_ACTIVATE | AW_VER_NEGATIVE | AW_SLIDE;
            //  TopToBottom = AW_ACTIVATE | AW_VER_POSITIVE | AW_SLIDE;
            //  RightToLeft = AW_ACTIVATE | AW_HOR_NEGATIVE | AW_SLIDE;
            //  LeftToRight = AW_ACTIVATE | AW_HOR_POSITIVE | AW_SLIDE;


            API.AnimateWindow(
                this.Handle,
                2000,
                ConstValues.AW_ACTIVATE |
                ConstValues.AW_VER_POSITIVE |
                ConstValues.AW_SLIDE
                );

            base.OnLoad(e);
        }
    }
}
