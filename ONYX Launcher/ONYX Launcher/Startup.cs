using System;
using System.Drawing;
using System.Windows.Forms;

namespace ONYX_Launcher{
    public partial class Startup : Form{
        private float current = 0;
        private float final = 500;
        private float smoothing = 0.025f;

        public Startup(){
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e){
            current = Lerp(current, final, smoothing);

            this.Size = new Size((int)current, (int)current);

            CenterFormOnScreen();

            if (Math.Abs(current - final) < 5){
                tick.Stop();
                Form main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private float Lerp(float a, float b, float t){
            return a + (b - a) * t;
        }

        private void CenterFormOnScreen(){
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int centerX = (screenWidth - this.Width) / 2;
            int centerY = (screenHeight - this.Height) / 2;

            this.Location = new Point(centerX, centerY);
        }
    }
}
