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
            EnabelPage(pnl_games, new Point(79, 39));
            
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            EnabelPage(pnl_news, new Point(160, 39));
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            EnabelPage(pnl_settings, new Point(241, 39));
        }

        private void EnabelPage(Panel pnl, Point underline_location)
        {
            pnl_games.Visible = false;
            pnl_news.Visible = false;
            pnl_settings.Visible = false;

            pnl.Size = new Size(960, 480);
            pnl.Location = new Point(0, 60);
            pnl.Visible = true;
            lbl_underline.Location = underline_location;
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
