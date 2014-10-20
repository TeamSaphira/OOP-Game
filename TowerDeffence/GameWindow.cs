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
<<<<<<< HEAD:TowerDeffence/GameWindow.cs
=======
using TowerDeffence.Interfaces;
using TowerDeffence.Helpers;
>>>>>>> origin/UserInput:TowerDeffence/Form1.cs

namespace TowerDeffence
{

    public partial class MainForm : Form
    {
        private Engine.Engine engine;

        public MainForm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD:TowerDeffence/GameWindow.cs

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.engine = new Engine.Engine();
            //this.engine.InitGame();
            //this.engine.InteractionManager.ShowGameMenu();
            var t = new InteractionManager();
            t.ShowGameMenu(this);
=======
        private void MainForm_Load(object sender, EventArgs s)
        {
            IUserInputHandler controller = new KeyboardMouseUserInput(this);
            Engine.Engine engine = new Engine.Engine(controller);
>>>>>>> origin/UserInput:TowerDeffence/Form1.cs
        }
    }
}
