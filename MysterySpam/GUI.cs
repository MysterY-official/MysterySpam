using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalHotKey;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using System.Linq;
using System.Runtime.InteropServices;

namespace MysterySpam
{
    public partial class GUI : MaterialForm
    {
        String VersionString = "1.1";
        bool Running = false;
        static bool CopyPasteMode = true;
        static bool ChatKeyOn = false;
        static int ChatKey = 0;
        static bool RandomMode = false;
        static int RandomLetterCount = 1;
        static bool DelayOn = false;
        System.Threading.Timer Timer = new System.Threading.Timer(Timer_callback, null, Timeout.Infinite, Timeout.Infinite);
        static InputSimulator Input = new InputSimulator();
        static String SpamText2 = "";

        [DllImport("user32.dll")]
        internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll")]
        internal static extern bool CloseClipboard();

        [DllImport("user32.dll")]
        internal static extern bool SetClipboardData(uint uFormat, IntPtr data);

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public GUI()
        {
            InitializeComponent();
            
            this.Text = "MysterySpam - V" + VersionString;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen700,
                TextShade.WHITE
            );
            
            HotKeyManager hotKeyManager = new HotKeyManager();
            var hotKeyF8 = hotKeyManager.Register(Key.F8, System.Windows.Input.ModifierKeys.None);
            var hotKeyF9 = hotKeyManager.Register(Key.F9, System.Windows.Input.ModifierKeys.None);
            hotKeyManager.KeyPressed += HotKeyManagerPressed;

            KeyChooser.SelectedIndex = 0;
        }

        private void HotKeyManagerPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.HotKey.Key == Key.F8)
            {
                Running = true;
                Timer.Change(0, SpeedTrackBar.Value);
            }

            if (e.HotKey.Key == Key.F9)
            {
                Running = false;
                Timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Form InfoGUI = new InfoGUI();
            InfoGUI.ShowDialog(this);
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            if (Running)
            {
                Timer.Change(0, SpeedTrackBar.Value);
            }
            SpeedLabel.Text = "Speed: " + SpeedTrackBar.Value + "ms";
        }

        private static void Timer_callback(object state)
        {
            if (ChatKeyOn)
            {
                switch (ChatKey)
                {
                    case 0:
                        Input.Keyboard.KeyPress(VirtualKeyCode.VK_Y);
                        break;
                    case 1:
                        Input.Keyboard.KeyPress(VirtualKeyCode.VK_T);
                        break;
                    case 2:
                        Input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        break;
                    default:
                        break;
                }
            }

            if (DelayOn && ChatKeyOn)
            {
                Thread.Sleep(40);
            }

            if (!RandomMode)
            {
                if (CopyPasteMode)
                {
                    Input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                }
                else
                {
                    Input.Keyboard.TextEntry(SpamText2);
                }
            }
            else
            {
                if (CopyPasteMode)
                {
                    OpenClipboard(IntPtr.Zero);
                    var ptr = Marshal.StringToHGlobalUni(RandomString(RandomLetterCount));
                    SetClipboardData(13, ptr);
                    CloseClipboard();
                    Marshal.FreeHGlobal(ptr);
                    Input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                }
                else
                {
                    Input.Keyboard.TextEntry(RandomString(RandomLetterCount));
                }
            }

            if (DelayOn)
            {
                Thread.Sleep(40);
            }

            Input.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            if (DelayOn)
            {
                Thread.Sleep(40);
            }
        }

        private void CopyPasteModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CopyPasteModeButton.Checked)
            {
                CopyPasteMode = true;
                SpeedTrackBar.Minimum = 100;
            }
        }

        private void SimulateModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SimulateModeButton.Checked)
            {
                CopyPasteMode = false;
                if (SpeedTrackBar.Value < 250)
                {
                    SpeedTrackBar.Value = 250;
                }
                SpeedTrackBar.Minimum = 250;

                if (Running)
                {
                    Timer.Change(0, SpeedTrackBar.Value);
                }
                SpeedLabel.Text = "Speed: " + SpeedTrackBar.Value + "ms";
            }
        }

        private void SpamText_Change(object sender, EventArgs e)
        {
            if (!SpamText.Text.Equals(""))
            {
                Clipboard.SetText(SpamText.Text);
            }
            else
            {
                Clipboard.Clear();
            }
            SpamText2 = SpamText.Text;
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void KeyChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatKey = KeyChooser.SelectedIndex;
        }

        private void NeedsChatBox_CheckedChanged(object sender, EventArgs e)
        {
            ChatKeyOn = NeedsChatBox.Checked;
            KeyChooser.Enabled = NeedsChatBox.Checked;
        }

        private void RandomBox_CheckedChanged(object sender, EventArgs e)
        {
            RandomMode = RandomBox.Checked;

            if (RandomBox.Checked)
            {
                SpamText.Enabled = false;
                LetterCountBox.Enabled = true;
            }
            else
            {
                SpamText.Enabled = true;
                LetterCountBox.Enabled = false;
            }
        }

        private void LetterCountBox_Change(object sender, EventArgs e)
        {
            if (!LetterCountBox.Text.Equals("") && IsDigitsOnly(LetterCountBox.Text))
            {
                RandomLetterCount = Int16.Parse(LetterCountBox.Text);
            }
            else
            {
                RandomLetterCount = 1;
            }
        }

        private void DelayBox_CheckedChanged(object sender, EventArgs e)
        {
            DelayOn = DelayBox.Checked;
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
