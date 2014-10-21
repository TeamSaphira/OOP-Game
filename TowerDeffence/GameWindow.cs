namespace TowerDeffence
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Threading;

    using Engine;

    using GameObjects;
    using Graphics;
    using Helpers;

    public partial class MainForm : Form
    {
        public Engine.Engine Engine { get; private set; }
        private static readonly int TimeInterval = 1000;

        public MainForm()
        {
            var loadingThread = new Thread(new ThreadStart(ShowLoadingScreen));
            loadingThread.Start();

            //Thread.Sleep(1000);

            this.ClientSize = new Size(800, 600);

            var player = new Player("unnamed", 10, 500);
            var inputHandler = new KeyboardMouseUserInput(this);
            inputHandler.PressedC += (sender, args) => MessageBox.Show(@"c pressed");
            var playfield = new GamePlayfield();

            this.Engine = new Engine.Engine(player, inputHandler, playfield, new InteractionManager(),
                new RangeCollisionHandler(), new ScreenRenderer());

            playfield.Init();

            InitializeComponent();
            loadingThread.Abort();
        }

        private static void ShowLoadingScreen()
        {
            Application.Run(new LoadingScreen());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.engine = new Engine.Engine();
            //this.engine.InitGame();
            //this.engine.InteractionManager.ShowGameMenu();
            var t = new InteractionManager();
            t.ShowGameMenu(this);
            this.Engine.InteractionManager.ShowGameMenu(this);
        }
    }
}
