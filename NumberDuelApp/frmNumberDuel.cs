using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberDuelApp
{
    public partial class frmNumberDuel : Form
    {
        enum TurnEnum { player1, player2 };
        TurnEnum currentturn = TurnEnum.player1;

        TurnEnum winner;

        List<Button> lstbuttons;
        HashSet<Button> pinkbuttons = new();
        bool gameactive = false;
        int previousnum = 0;
        bool playcomputer = false;
        Color startcolor = Color.MediumSpringGreen;
        Color usedcolor = Color.Gray;
        Color wincolor = Color.Gold;
        Color setupwincolor = Color.Pink;

       
        public frmNumberDuel()
        {
            InitializeComponent();
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8,
                btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };

            lstbuttons.ForEach(b => b.Click += Button_Click);
            btnStart.Click += BtnStart_Click;
            rbnPlayComp.CheckedChanged += Mode;
            rbn2Player.CheckedChanged += Mode;
            DisplayGameStatus();

        }

        private void StartGame()
        {
            gameactive = true;
            currentturn = TurnEnum.player1;
            playcomputer = rbnPlayComp.Checked;
            previousnum = 0;
            lblNumPicked.Text = "";

            lstbuttons.ForEach(b =>
            {
                b.Enabled = true;
                b.BackColor = startcolor;
            });
            pinkbuttons.Clear();

            HighlightOneAndFinisherMoves();
    

            DisplayGameStatus();
        }

        private void DoTurn()
        {
          if (!gameactive)
            {
                return;
            }
          if (DetectWinner())
            {
                return;
            }
          SwitchTurn();
          DisplayGameStatus();
          HighlightOneAndFinisherMoves();

            if (IsComputerTurn())
            {
                DoComputerTurn();
            }
            
        }

        private void DoComputerTurn()
        {
          var lst = lstbuttons.Where(b => b.Enabled && ValidMove(int.Parse(b.Text))).ToList();

          if (lst.Count == 0)
            {
                return ;
            }
            Button bestbutton = lst[0];
            int bestscore = CountMovesLeft(int.Parse(bestbutton.Text), bestbutton);
            foreach(Button b in lst)
            {
                int num = int.Parse(b.Text);
                int score = CountMovesLeft(num, b);

                if (score == 0)
                {
                    HandleMove(b);
                    return;
                }
                if (score < bestscore) 
                {
                    bestscore = score;
                    bestbutton = b;
                }

            }
            HandleMove(bestbutton);
        }

        private int CountMovesLeft(int testnum, Button testbutton)
        {
            int count = 0;
            int original = previousnum;
            previousnum = testnum;

            foreach(Button b in lstbuttons)
            {
                if (b.Enabled && b != testbutton)
                {
                    int num = int.Parse(b.Text);

                    if (ValidMove(num))
                    {
                        count++;
                    }
                } 
            }
            previousnum = original;
            return count;
        }

        private bool IsComputerTurn()
        {
            return playcomputer && currentturn == TurnEnum.player2;
        }

        private void SwitchTurn()
        {
            currentturn = currentturn == TurnEnum.player1 ? TurnEnum.player2 : TurnEnum.player1;
        }

      
        private void Mode (object ?  sender, EventArgs e)
        {
            if (gameactive)
            {
                return;
            }
            playcomputer = rbnPlayComp.Checked;
            DisplayGameStatus();
        }
       
        private string GetPlayerName(TurnEnum turn)
        {
            if (!playcomputer)
            {
                return turn.ToString();
            }
            if (turn == TurnEnum.player1)
            {
                return "Player";
            }
            return "Computer";
        }
        
        private void DisplayGameStatus()
        {
            string msg = "Click Start to begin game";
            if (gameactive)
            {
                msg = GetPlayerName(currentturn);
            }
            else if (previousnum != 0)
            {
                msg = "Winner: " + GetPlayerName(winner) + " !";
            }

            msg = (playcomputer ? rbnPlayComp.Text : rbn2Player.Text) + Environment.NewLine + msg;

            lblGameStat.Text = msg;
        }

        private bool ValidMove(int num)
        {
            if (previousnum == 0)
            {
                return true;
            }
            int sum = num;
            while (sum <= previousnum)
            {
                if (sum == previousnum)
                {
                    return true;
                }
                sum = sum + num;
            }

            sum = previousnum;
            while (sum <= num)
            {
                if (sum == num)
                {
                    return true;
                }
                sum = sum + previousnum;
            }
            return false;
        }

        private bool DetectWinner()
        {
            foreach(Button b in lstbuttons)
            {
                if (b.Enabled)
                {
                    int num = int.Parse(b.Text);
                    if (ValidMove(num))
                    {
                        return false;
                    }
                }
            }
            gameactive = false;
            winner = currentturn;            
            lstbuttons.ForEach(b =>
            {
                if (!b.Enabled)
                {
                    b.BackColor = wincolor;
                }
            });

            DisplayGameStatus();
            return true;           
            
        }

        private void HighlightOneAndFinisherMoves()
        {
            if (!gameactive)
            {
                return;
            }

            foreach (Button b in lstbuttons.Where(b => b.Enabled))
            {
                b.BackColor = pinkbuttons.Contains(b) ? setupwincolor : startcolor;
            }

            var validMoves = lstbuttons
                .Where(b => b.Enabled && ValidMove(int.Parse(b.Text)))
                .ToList();

            if (validMoves.Count != 1)
            {
                return;
            }

            Button forcedMove = validMoves[0];
            if (int.Parse(forcedMove.Text) != 1)
            {
                return;
            }

            var finishingMoves = GetImmediateFinishingMovesAfterForcedOne(forcedMove);
            if (finishingMoves.Count > 0)
            {
                pinkbuttons.Add(forcedMove);
                finishingMoves.ForEach(b => pinkbuttons.Add(b));

                foreach (Button b in lstbuttons.Where(b => b.Enabled && pinkbuttons.Contains(b)))
                {
                    b.BackColor = setupwincolor;
                }
            }
        }

        private List<Button> GetImmediateFinishingMovesAfterForcedOne(Button forcedOne)
        {
            int originalPrevious = previousnum;
            previousnum = 1;
            List<Button> finishingMoves = new();

            foreach (Button b in lstbuttons)
            {
                if (!b.Enabled || b == forcedOne)
                {
                    continue;
                }

                int candidateNum = int.Parse(b.Text);
                if (!ValidMove(candidateNum))
                {
                    continue;
                }

                if (EndsGameImmediatelyAfterChoice(b, forcedOne))
                {
                    finishingMoves.Add(b);
                }
            }

            previousnum = originalPrevious;
            return finishingMoves;
        }

        private bool EndsGameImmediatelyAfterChoice(Button selectedMove, Button forcedOne)
        {
            int originalPrevious = previousnum;
            previousnum = int.Parse(selectedMove.Text);

            foreach (Button b in lstbuttons)
            {
                if (!b.Enabled || b == forcedOne || b == selectedMove)
                {
                    continue;
                }

                if (ValidMove(int.Parse(b.Text)))
                {
                    previousnum = originalPrevious;
                    return false;
                }
            }

            previousnum = originalPrevious;
            return true;
        }

        private void HandleMove(Button btn)
        {
            int num = int.Parse(btn.Text);

            if (!ValidMove(num))
            {
                return;
            }
            previousnum = num;
            lblNumPicked.Text = "Number: " + btn.Text;
            btn.Enabled = false;
            pinkbuttons.Remove(btn);
            btn.BackColor = usedcolor;

            DoTurn();

        }
       
        private void Button_Click(object? sender, EventArgs e)
        {
          if(!gameactive)
                return;

          if (sender is Button btn)
            {
                HandleMove(btn);
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
