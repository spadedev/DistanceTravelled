using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTravelled
{
    public partial class DistanceTravelled : Form
    {
        public DistanceTravelled()
        {
            InitializeComponent();
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            int speed;
            int result;
            speed = Convert.ToInt16(enter_txtbox.Text);
            result = speed * 5;
            result_txtbox.Text = result.ToString();
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            int speed;
            int result;
            speed = Convert.ToInt16(enter_txtbox.Text);
            result = speed * 8;
            result_txtbox.Text = result.ToString();
        }

        private void twelve_btn_Click(object sender, EventArgs e)
        {
            int speed;
            int result;
            speed = Convert.ToInt16(enter_txtbox.Text);
            result = speed * 12;
            result_txtbox.Text = result.ToString();
        }
    }
}
