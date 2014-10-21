using System;
using System.Windows.Forms;

namespace TowerDeffence
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadBar.Increment(1);
            if (loadBar.Value.Equals(100))
            {
                loadTimer.Stop();
            }
        }
    }
}
