using NumberDuelSystem;
namespace NumberDuelMAUI
{
    public partial class NumberDuel : ContentPage
    {
        Game game = new();
        List<Button> lstbuttons;
        public NumberDuel()
        {
            InitializeComponent();
            this.BindingContext = game;
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };
        }
        private void StartBtn_Clicked(object sender, EventArgs e)
        {
            game.StartGame(rbnCompPlay.IsChecked);
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            game.HandleMove(game.Btns[lstbuttons.IndexOf((Button)sender)]);
        }
    }
}
