using Sound.Mp3;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MediaPlayer
{
    static class Program
    {
        static readonly AutoResetEvent autoEvent = new AutoResetEvent(false);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                var mp3Player = new MP3Player(args[0], true);
                mp3Player.PlayStopped += mp3PlayerPlayStopped;
                mp3Player.Play();
                
                autoEvent.WaitOne();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        static void mp3PlayerPlayStopped(object sender, EventArgs e)
        {
            autoEvent.Set();
        }
    }
}
