using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalHotKey;

namespace MysterySpam
{
    public partial class GUI : MaterialForm
    {
        private bool Running = false;
        String VersionString = "0.1";

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
            }

            if (e.HotKey.Key == Key.F9)
            {
                Running = false;
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Form InfoGUI = new InfoGUI();
            InfoGUI.ShowDialog(this);
        }
    }
}
