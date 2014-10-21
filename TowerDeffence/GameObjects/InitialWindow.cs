using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDeffence.GameObjects
{
    public partial class InitialWindow : Form
    {
        public InitialWindow()
        {
            InitializeComponent();
        }

        private void InitialWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            //Load Engine
        }

        private void labelTitleGame_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            string playerName = "";
            if(String.IsNullOrEmpty(name.Text) ||
                name.Text[0] == ' ')
            {
                MessageBox.Show("You must enter valid name! Names can not begin with a space");
                return;
            }
            playerName = name.Text;
        }

        private void labelPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
