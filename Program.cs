using Sticky_Notes.Forms;
using Sticky_Notes.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {

                Taskbar oTaskbar = new Taskbar();

                SplashForm splashForm = new SplashForm();

                if (splashForm.Height > (ScreenArea.MaximumHeight - oTaskbar.Size.Height))
                {
                    splashForm.Location =
                        new Point(splashForm.Height - ScreenArea.MaximumHeight);
                }

                Application.Run(splashForm);

                MenuForm menuForm = new MenuForm();

                Application.Run(menuForm);
            }
            catch (System.Exception)
            {
                Application.Restart();
            }
        }
    }
}
