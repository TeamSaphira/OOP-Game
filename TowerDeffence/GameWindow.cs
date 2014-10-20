using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerDeffence.Engine;
using TowerDeffence.GameObjects;
using TowerDeffence.Interfaces;
using TowerDeffence.Helpers;

namespace TowerDeffence
{

    public partial class MainForm : Form
    {
        private Engine.Engine engine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.engine = new Engine.Engine();
            //this.engine.InitGame();
            //this.engine.InteractionManager.ShowGameMenu();
            this.ClientSize = new Size(800, 600);
            var t = new InteractionManager();
            t.ShowGameMenu(this);
        }
    }
}
