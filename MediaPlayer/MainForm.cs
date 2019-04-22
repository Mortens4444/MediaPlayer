using Sound.Mp3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class MainForm : Form
    {
        bool stopped;
        int actIndex;
        MP3Player mp3Player;

        public MainForm()
        {
            InitializeComponent();            
        }

        void tsb_AddFiles_Click(object sender, EventArgs e)
        {
            if (ofd_FileSelector.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in ofd_FileSelector.FileNames)
                {
                    lv_Playlist.Items.Add(new ListViewItem(filename));
                }
            }
        }

        void btn_Play_Click(object sender, EventArgs e)
        {
            actIndex = 0;
            PlayNextFile();
        }

        void PlayNextFile()
        {
            ClosePreviousWindows();

            if (lv_Playlist.Items.Count > actIndex)
            {
                var filename = lv_Playlist.Items[actIndex++].Text;
                tssl_Status.Text = String.Concat("Playing: ", filename);
                mp3Player = new MP3Player(filename);
                mp3Player.PlayStopped += mp3_player_PlayStopped;
                mp3Player.Play();

                var windows = GetOpenWindowsFromProcessId(Process.GetCurrentProcess().Id);
                foreach (KeyValuePair<IntPtr, string> kvp in windows)
                {
                    if (filename == kvp.Value)
                    {
                        var style = WinAPI.GetWindowLong(kvp.Key, -16);
                        style &= -12582913;
                        WinAPI.SetWindowLong(kvp.Key, -16, style);

                        WinAPI.SetWindowPos(kvp.Key, WinAPI.HWND_TOPMOST,
                            0, 0,
                            Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,
                            SetWindowPosFlags.DoNotReposition | SetWindowPosFlags.ShowWindow);
                    }
                }
            }
        }

        public IDictionary<IntPtr, string> GetOpenWindowsFromProcessId(int process_id)
        {
            var shellWindowHandle = WinAPI.GetShellWindow();
            var windows = new Dictionary<IntPtr, string>();

            WinAPI.EnumWindows(delegate(IntPtr hWnd, int lParam)
                {
                    if (hWnd == shellWindowHandle)
                    {
                        return true;
                    }

                    if (!WinAPI.IsWindowVisible(hWnd))
                    {
                        return true;
                    }

                    int length = WinAPI.GetWindowTextLength(hWnd);
                    if (length == 0)
                    {
                        return true;
                    }

                    uint windowPid;
                    WinAPI.GetWindowThreadProcessId(hWnd, out windowPid);
                    
                    if (windowPid != process_id)
                    {
                        return true;
                    }

                    var sb = new StringBuilder(length);
                    WinAPI.GetWindowText(hWnd, sb, length + 1);
                    windows.Add(hWnd, sb.ToString());
                    return true;
                }, 0);

            return windows;
        }

        void mp3_player_PlayStopped(object sender, EventArgs e)
        {
            if (!stopped)
            {
                PlayNextFile();
            }
            else
            {
                stopped = false;
            }
        }

        void btn_Stop_Click(object sender, EventArgs e)
        {
            stopped = true;
            Stop();
        }

        void btn_Next_Click(object sender, EventArgs e)
        {
            Stop();
        }

        void btn_Previous_Click(object sender, EventArgs e)
        {
            actIndex -= 2;
            if (actIndex < 0)
            {
                actIndex = 0;
            }
            Stop();
        }

        void Stop()
        {
            ClosePreviousWindows();

            tssl_Status.Text = "Stopped";
            if (mp3Player != null)
            {
                mp3Player.Stop();
            }
        }

        void ClosePreviousWindows()
        {
            if (actIndex > 0)
            {
                var filename = lv_Playlist.Items[actIndex - 1].Text;
                var windows = GetOpenWindowsFromProcessId(Process.GetCurrentProcess().Id);
                foreach (KeyValuePair<IntPtr, string> kvp in windows)
                {
                    if (filename == kvp.Value)
                    {
                        WinAPI.DestroyWindow(kvp.Key);
                    }
                }
            }
        }

        void lv_Playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv_Playlist.SelectedItems.Count != 1)
            {
                return;
            }

            actIndex = lv_Playlist.SelectedItems[0].Index;
            Stop();
        }
    }
}
