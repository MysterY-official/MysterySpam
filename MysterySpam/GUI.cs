using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalHotKey;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace MysterySpam
{
    public partial class GUI : MaterialForm
    {
        String VersionString = "0.2";
        bool Running = false;
        static bool CopyPasteMode = true;
        System.Threading.Timer Timer = new System.Threading.Timer(Timer_callback, null, Timeout.Infinite, Timeout.Infinite);
        static InputSimulator Input = new InputSimulator();
        static String SpamText2 = "";

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
        }

        private void HotKeyManagerPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.HotKey.Key == Key.F8)
            {
                Running = true;
                if (!SpamText.Text.Equals(""))
                {
                    Clipboard.SetText(SpamText.Text);
                }
                else
                {
                    Clipboard.Clear();
                }
                SpamText2 = SpamText.Text;
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
            if (CopyPasteMode)
            {
                Input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                Input.Keyboard.KeyDown(VirtualKeyCode.RETURN);
            }
            else
            {
                Input.Keyboard.TextEntry(SpamText2);
                Input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
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
    }
}
