using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDeffence
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Test(object sender, EventArgs e)
        {
            var btn = new Button() {Text = @"Test button", Location = new Point(100, 250), Size = new Size(150,150) };
            
            this.Controls.Add(btn);
        }
    }
}
