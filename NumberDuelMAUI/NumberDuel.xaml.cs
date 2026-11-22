using NumberDuelSystem;
namespace NumberDuelMAUI
{
    public partial class NumberDuel : ContentPage
    {
        Game activegame;
        List<Game> lstgame = new() { new Game(), new Game(), new Game() };
        List<Button> lstbuttons;
        public NumberDuel()
        {
            InitializeComponent();
            lstgame.ForEach(g => g.ScoreChanged += G_ScoreChanged);
            Game1Rb.BindingContext = lstgame[0];
            Game2Rb.BindingContext = lstgame[1];
            Game3Rb.BindingContext = lstgame[2];
            activegame = lstgame[0];
            this.BindingContext = activegame;
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };
        }

        private void G_ScoreChanged(object? sender, EventArgs e)
        {
            ScoreLbl.Text = Game.Score;
        }

        private void StartBtn_Clicked(object sender, EventArgs e)
        {
            if (activegame.GameStatus == Game.GameStatusEnum.NotStarted)
            {
                activegame.StartGame(rbnCompPlay.IsChecked);
            }
            else
            {
                activegame.StopGame();
            }
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            activegame.HandleMove(activegame.Btns[lstbuttons.IndexOf((Button)sender)]);
        }

        private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.IsChecked && rb.BindingContext != null)
            {
                activegame = (Game)rb.BindingContext;
                this.BindingContext = activegame;
            }
        }
    }
}
