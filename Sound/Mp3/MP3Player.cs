using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Sound.Mp3
{
	public partial class MP3Player : Form
	{
		public const int MM_MCINOTIFY = 0x3B9;

		[DllImport("winmm.dll")]
		public static extern long mciSendString(string strCommand, StringBuilder strReturn, int returnedLength, IntPtr hwndCallback);

		public event EventHandler PlayStopped;

        bool stopOnIsPlayingFlag;

        public bool IsPlaying { get; private set; }

		readonly string media;

		void OnPlayStopped(EventArgs e)
		{
			var handler = PlayStopped;
            if (handler != null)
            {
                handler(this, e);
            }
		}

		public MP3Player(string filename, bool stopOnIsPlayingFlag = false)
		{
			InitializeComponent();
            this.stopOnIsPlayingFlag = stopOnIsPlayingFlag;
			media = Guid.NewGuid().ToString();
			var command = String.Format("Open \"{0}\" type mpegvideo alias {1}", filename, media);
			CommandExecuter(command, IntPtr.Zero);
		}

		~MP3Player()
		{
			var command = String.Concat("Close ", media);
			CommandExecuter(command, IntPtr.Zero);
		}

		protected override void WndProc(ref Message m)
		{
            if (stopOnIsPlayingFlag)
            {
                if (IsPlaying)
                {
                    IsPlaying = false;
                    OnPlayStopped(EventArgs.Empty);
                }
            }
            else
            {
                if (m.Msg == MM_MCINOTIFY)
                {
                    IsPlaying = false;
                    OnPlayStopped(EventArgs.Empty);
                }
            }

            base.WndProc(ref m);
		}

		public void Play(bool loop = false)
		{
			var command = String.Format(loop ? "Play {0} REPEAT notify" : "Play {0} notify", media);
			CommandExecuter(command, Handle);
		}

		public void Stop()
		{
			var command = String.Concat("Stop ", media);
			CommandExecuter(command, IntPtr.Zero);
		}

		void CommandExecuter(string command, IntPtr notifyHandle)
		{
			mciSendString(command, null, 0, notifyHandle);
            IsPlaying = command.StartsWith("Play ");
		}
	}
}
