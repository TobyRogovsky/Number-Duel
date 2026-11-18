using NumberDuelSystem;

namespace NumberDuelApp
{
    public partial class frmNumberDuel : Form
    {
        Game game = new();
        List<Button> lstbuttons;
        public frmNumberDuel()
        {
            InitializeComponent();
            lblGameStat.DataBindings.Add("Text", game, "GameStatusDescription");
            lblNumPicked.DataBindings.Add("Text", game, "NumberPickedDescription");
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };
            for (int index = 0; index < lstbuttons.Count; index++)
            {
                lstbuttons[index].DataBindings.Add("Enabled", game.Btns[index], "Enabled");
                lstbuttons[index].DataBindings.Add("BackColor", game.Btns[index], "BackColor");
            }
            foreach (Button btn in lstbuttons)
            {
                btn.Click += Button_Click;
            }
            btnStart.Click += BtnStart_Click;
            rbnPlayComp.CheckedChanged += Mode;
            rbn2Player.CheckedChanged += Mode;           
        }
        private void StartGame()
        {
            game.StartGame(rbnPlayComp.Checked);
        }                  
        private void Mode(object? sender, EventArgs e)
        {
            if (game.GameStatus == Game.GameStatusEnum.Playing)
            {
                return;
            }
            game.PlayAgainstComputer = rbnPlayComp.Checked;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int index = lstbuttons.IndexOf(btn);
                game.HandleMove(game.Btns[index]);
            }
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
