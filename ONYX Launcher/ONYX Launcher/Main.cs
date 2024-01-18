using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONYX_Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new Size(960, 540);
            CenterFormOnScreen();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_games_Click(object sender, EventArgs e)
        {
            HideAllPanles();
            pnl_games.Size = new Size(960, 480);
            pnl_games.Location = new Point(0, 60);
            pnl_games.Visible = true;
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            HideAllPanles();
            pnl_news.Size = new Size(960, 480);
            pnl_news.Location = new Point(0, 60);
            pnl_news.Visible = true;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            HideAllPanles();
            pnl_settings.Size = new Size(960, 480);
            pnl_settings.Location = new Point(0, 60);
            pnl_settings.Visible = true;
        }

        private void HideAllPanles()
        {
            pnl_games.Visible = false;
            pnl_news.Visible = false;
            pnl_settings.Visible = false;
        }

        private void CenterFormOnScreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int centerX = (screenWidth - this.Width) / 2;
            int centerY = (screenHeight - this.Height) / 2;

            this.Location = new Point(centerX, centerY);
        }
    }
}
