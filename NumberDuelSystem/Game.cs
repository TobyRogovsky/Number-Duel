using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NumberDuelSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? ScoreChanged;
        public enum GameStatusEnum { NotStarted, Playing, Winner }
        public enum TurnEnum { Player1, Player2, None }
        public List<Btns> Btns { get; private set; } = new();
        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;
        TurnEnum _currentturn = TurnEnum.None;
        int _previousnum = 0;
        private static int score1wins;
        private static int score2wins;        
        private static int numgames;

        public Game()
        {
            numgames++;
            this.GameName = "Game " + numgames;
            for (int num = 1; num <= 16; num++)
            {
                Btns.Add(new Btns { Num = num });
            }
        }
        public GameStatusEnum GameStatus
        {
            get => _gamestatus; private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
                this.InvokePropertyChanged("StartButtonText");
            }
        }
        public TurnEnum CurrentTurn
        {
            get => _currentturn; private set
            {
                _currentturn = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
                this.InvokePropertyChanged("StartButtonText");
            }
        }
        public string GameStatusDescription
        {
            get
            {
                string s = $"{this.GameName}, {this.GameMode} : ";
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + "Click Start";
                        break;

                    case GameStatusEnum.Playing:
                        s = s + " Current Turn " + this.CurrentTurn;
                        break;
                    case GameStatusEnum.Winner:
                        s = s + this.GameStatus + " is " + this.CurrentTurn;
                        break;
                    
                }
                return s;
            }

        }


        public TurnEnum Winner { get; private set; } = TurnEnum.None;
        public int PreviousNum
        {
            get => _previousnum; private set
            {
                _previousnum = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("NumberPickedDescription");
            }
        }

        public string NumberPickedDescription
        {
            get
            {
                if (PreviousNum == 0)
                {
                    return "";
                }

                return "Number: " + PreviousNum;
            }
        }

        public string GameMode { get => this.PlayAgainstComputer ? "Play the Computer" : "2 Player"; }
        public string GameModeHeader { get => "For " + this.GameName; }
        public string GameName { get; private set; }
        public bool PlayAgainstComputer { get; set; }
        public System.Drawing.Color StartColor { get; set; } = System.Drawing.Color.MediumSpringGreen;
        public System.Drawing.Color UsedColor { get; set; } = System.Drawing.Color.Gray;
        public System.Drawing.Color WinColor { get; set; } = System.Drawing.Color.Gold;
        public System.Drawing.Color SetupWinColor { get; set; } = System.Drawing.Color.Pink;
        public static string Score { get => $"Player 1 wins = {score1wins}: Player 2 wins = {score2wins}: "; }
        public string StartButtonText
        {
            get
            {
                string s = "";
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = "Start ";
                        break;
                    case GameStatusEnum.Playing:
                    case GameStatusEnum.Winner:                    
                        s = "Stop ";
                        break;
                }
                s = s + this.GameName;
                return s;
            }
        }

        public void StartGame(bool playcomputer = false)
        {
            this.GameStatus = GameStatusEnum.Playing;
            this.CurrentTurn = TurnEnum.Player1;
            this.Winner = TurnEnum.None;
            this.PlayAgainstComputer = playcomputer;
            this.PreviousNum = 0;
            ClearButtons();
            HighlightOneAndFinisherMoves();
        }

        public void StopGame()
        {
            this.GameStatus = GameStatusEnum.NotStarted;
            ClearButtons();
        }

        private void ClearButtons()
        {
            this.Btns.ForEach(b =>
            {
                b.Clear();
                b.BackColor = this.StartColor;
            });
        }

        public void HandleMove(Btns btn)
        {
            if (GameStatus != GameStatusEnum.Playing || !btn.Enabled)
            {
                return;
            }
            int num = btn.Num;
            if (!ValidMove(num))
            {
                return;
            }
            PreviousNum = num;
            btn.Enabled = false;
            btn.EasyWin = false;
            btn.BackColor = UsedColor;
            DoTurn();
        }

        public void DoTurn()
        {
            if (GameStatus != GameStatusEnum.Playing)
            {
                return;
            }
            if (DetectWinner())
            {
                return;
            }
            SwitchTurn();
            HighlightOneAndFinisherMoves();
            if (PlayAgainstComputer && CurrentTurn == TurnEnum.Player2)
            {
                DoComputerTurn();
            }
        }

        public bool ValidMove(int num)
        {
            if (PreviousNum == 0)
            {
                return true;
            }
            int sum = num; while (sum <= PreviousNum)
            {
                if (sum == PreviousNum)
                {
                    return true;
                }
                sum = sum + num;
            }
            sum = PreviousNum; while (sum <= num)
            {
                if (sum == num)
                {
                    return true;
                }
                sum = sum + PreviousNum;
            }
            return false;
        }

        public bool DetectWinner()
        {
            foreach (Btns b in Btns)
            {
                if (b.Enabled)
                {
                    int num = b.Num;
                    if (ValidMove(num))
                    {
                        return false;
                    }
                }
            }
            Winner = CurrentTurn;
            GameStatus = GameStatusEnum.Winner;
            Btns.ForEach(b =>
            {
                if (!b.Enabled)
                {
                    b.BackColor = WinColor;
                }
            });
            if (this.CurrentTurn == TurnEnum.Player1)
            {
                score1wins++;
            }
            else
            {
                score2wins++;
            }
            ScoreChanged?.Invoke(this, new EventArgs());
            return true;
        }

        public void SwitchTurn()
        {
            CurrentTurn = CurrentTurn == TurnEnum.Player1 ? TurnEnum.Player2 : TurnEnum.Player1;
        }

        public void DoComputerTurn()
        {
            var lst = Btns.Where(b => b.Enabled && ValidMove(b.Num)).ToList();
            if (lst.Count == 0)
            {
                return;
            }
            Btns bestbutton = lst[0];
            int bestscore = CountMovesLeft(bestbutton.Num, bestbutton);
            foreach (Btns b in lst)
            {
                int num = b.Num;
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

        public void HighlightOneAndFinisherMoves()
        {
            if (GameStatus != GameStatusEnum.Playing)
            {
                return;
            }
            List<Btns> validmoves = new();
            foreach (Btns b in Btns)
            {
                if (b.Enabled && ValidMove(b.Num))
                {
                    validmoves.Add(b);
                }
            }
            if (validmoves.Count != 1)
            {
                return;
            }
            Btns forcedmove = validmoves[0];
            if (forcedmove.Num != 1)
            {
                return;
            }
            List<Btns> finishingmoves = new();
            int originalprevious = PreviousNum;
            foreach (Btns candidate in Btns)
            {
                if (!candidate.Enabled || candidate == forcedmove)
                {
                    continue;
                }
                PreviousNum = candidate.Num;
                bool hasnextmove = false;
                foreach (Btns next in Btns)
                {
                    if (next.Enabled && next != forcedmove && next != candidate && ValidMove(next.Num))
                    {
                        hasnextmove = true;
                        break;
                    }
                }
                if (!hasnextmove)
                {
                    finishingmoves.Add(candidate);
                }
            }
            PreviousNum = originalprevious;
            if (finishingmoves.Count > 0)
            {
                forcedmove.EasyWin = true;
                forcedmove.BackColor = SetupWinColor;
                foreach (Btns b in finishingmoves)
                {
                    b.EasyWin = true;
                    b.BackColor = SetupWinColor;
                }
            }
        }

        public int CountMovesLeft(int num, Btns btn)
        {
            int count = 0;
            int original = PreviousNum;
            PreviousNum = num;
            foreach (Btns b in Btns)
            {
                if (b.Enabled && b != btn && ValidMove(b.Num))
                {
                    count++;
                }
            }
            PreviousNum = original;
            return count;
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
