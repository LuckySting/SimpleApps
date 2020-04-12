using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        ToolTip tooltip;
        public Form1()
        {
            InitializeComponent();
            this.RedTrack.Value = 125;
            this.GreenTrack.Value = 125;
            this.BlueTrack.Value = 125;
            this.RedTrack.ValueChanged += new EventHandler(this.change_color);
            this.GreenTrack.ValueChanged += new EventHandler(this.change_color);
            this.BlueTrack.ValueChanged += new EventHandler(this.change_color);
            this.tooltip = new ToolTip();
            this.tooltip.InitialDelay = 1000;
            change_color(null, null);
        }

        private void change_color(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(this.RedTrack.Value, this.GreenTrack.Value, this.BlueTrack.Value);
            this.ColorBox.BackColor = color;
            String hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            Clipboard.SetText(hex);
            this.tooltip.SetToolTip(this.ColorBox, hex);
        }
    }
}
