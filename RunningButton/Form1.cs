using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApps
{
    public partial class MainForm : Form
    {
        int prev_width;
        int prev_height;
        public MainForm()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(this.mouse_move);
            this.Resize += new EventHandler(this.form_resize);
            this.prev_width = this.ClientSize.Width;
            this.prev_height = this.ClientSize.Height;
        }

        private void RunningButton_click(object sender, EventArgs e)
        {
            string message = "Поздравляем! Вы смогли нажать на кнопку!";
            string caption = "Congratulations!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            this.RunningButton.Location = new Point(this.ClientSize.Width / 2 - this.RunningButton.Width / 2, this.ClientSize.Height / 2 - this.RunningButton.Height / 2);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            int CX = this.RunningButton.Location.X;
            int CY = this.RunningButton.Location.Y;

            int final_X = CX;
            int final_Y = CY;
            int prev_X = final_X;
            int prev_Y = final_Y;

            double distance = Math.Sqrt(Math.Pow((final_X - e.X), 2) + Math.Pow((final_Y - e.Y), 2));

            while (distance < 200)
            {
                final_X += Math.Sign(CX + this.RunningButton.Width / 2 - e.X);
                final_Y += Math.Sign(CY + this.RunningButton.Height / 2 - e.Y);

                if (final_X + this.RunningButton.Width >= this.ClientSize.Width)
                {
                    final_X = this.ClientSize.Width - this.RunningButton.Width;
                }

                if (final_X < 0)
                {
                    final_X = 0;
                }

                if (final_Y + this.RunningButton.Height >= this.ClientSize.Height)
                {
                    final_Y = this.ClientSize.Height - this.RunningButton.Height;
                }

                if (final_Y < 0)
                {
                    final_Y = 0;
                }

                distance = Math.Sqrt(Math.Pow((final_X - e.X), 2) + Math.Pow((final_Y - e.Y), 2));

                if (prev_X == final_X && prev_Y == final_Y)
                {
                    break;
                }

                prev_X = final_X;
                prev_Y = final_Y;
            }

            this.RunningButton.Location = new Point(final_X, final_Y);
        }

        private void form_resize(object sender, EventArgs e)
        {
            int path_x = (this.ClientSize.Width - this.prev_width) / 2;
            int path_y = (this.ClientSize.Height - this.prev_height) / 2;

            this.RunningButton.Location = new Point(this.RunningButton.Location.X + path_x, this.RunningButton.Location.Y + path_y);

            this.prev_width = this.ClientSize.Width;
            this.prev_height = this.ClientSize.Height;
        }
    }
}
