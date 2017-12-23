using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace MysterySpam
{
    public partial class InfoGUI : MaterialForm
    {
        public InfoGUI()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen700,
                TextShade.WHITE
            );
        }

        private void InfoGUI_Load(object sender, EventArgs e)
        {

        }

        private void YTButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCeH0nCIjzI8TFHdP65tSQ4w");
        }

        private void SkinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IgnaceMaes/MaterialSkin");
        }
    }
}
