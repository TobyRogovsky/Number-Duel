using NumberDuelSystem;
namespace NumberDuelTest
{
    public class Tests
    {
        [Test]
        public void TestStartGame()
        {
            Game game = new Game();
            game.StartGame();
            string msg = $"game status = {game.GameStatus.ToString()} current turn = {game.CurrentTurn.ToString()} num buttons = {game.Btns.Count()}";
            Assert.That(game.GameStatus == Game.GameStatusEnum.Playing && game.CurrentTurn == Game.TurnEnum.Player1 && game.Btns.Count == 16, msg);
            TestContext.Out.WriteLine(msg);
        }
        [Test]
        public void DoTurn()
        {
            Game game = new();
            game.StartGame();
            game.HandleMove(game.Btns[0]);
            string msg = $"spot 0 = {game.Btns[0].Num.ToString()} current turn = {game.CurrentTurn.ToString()}";
            Assert.That(game.Btns[0].Num == 1 &&  game.CurrentTurn == Game.TurnEnum.Player2, msg);
            TestContext.Out.WriteLine(msg);
        }

        [Test]
        public void TestPlayComputer()
        {
            Game game = new();            
            game.StartGame(true);
            game.HandleMove(game.Btns[0]);
            int usedbuttons = game.Btns.Count(b => !b.Enabled);
            string msg = $"used buttons = {usedbuttons} current turn = {game.CurrentTurn}";            
            Assert.That(usedbuttons == 2 &&((game.GameStatus == Game.GameStatusEnum.Playing && game.CurrentTurn == Game.TurnEnum.Player1)
                ||(game.GameStatus == Game.GameStatusEnum.Winner && game.Winner == Game.TurnEnum.Player2)), msg);
            TestContext.Out.WriteLine(msg);
        }
        [Test]
        public void TestWinner()
        {
            Game game = new();
            game.StartGame();
            game.HandleMove(game.Btns[0]);  
            game.HandleMove(game.Btns[10]);
            string msg = $"status = {game.GameStatus}, winner = {game.Winner}";
            Assert.That(game.GameStatus == Game.GameStatusEnum.Winner && game.Winner == Game.TurnEnum.Player2,msg);
            TestContext.Out.WriteLine(msg);
        }

        [Test]
        public void TestInvalidMove()
        {
            Game game = new();
            game.StartGame();
            game.HandleMove(game.Btns[1]); 
            game.HandleMove(game.Btns[2]); 
            string msg = $"previous number = {game.PreviousNum}, 3 enabled = {game.Btns[2].Enabled}, turn = {game.CurrentTurn}";
            Assert.That(game.PreviousNum == 2 && game.Btns[2].Enabled && game.CurrentTurn == Game.TurnEnum.Player2, msg);
            TestContext.Out.WriteLine(msg);
        }

        [Test]
        public void TestComputerTakesBestMove()
        {
            Game game = new();
            game.StartGame(true);
            game.HandleMove(game.Btns[1]);           
            string msg = $"computer chose = {game.PreviousNum}";
            Assert.That(game.PreviousNum == 10 && !game.Btns[9].Enabled,msg);
            TestContext.Out.WriteLine(msg);
        }

        [Test]
        public void TestComputerOffense()
        {
            Game game = new();
            game.StartGame(true);
            game.HandleMove(game.Btns[0]);             
            string msg = $"status = {game.GameStatus}, winner = {game.Winner}";
            Assert.That(game.GameStatus == Game.GameStatusEnum.Winner && game.Winner == Game.TurnEnum.Player2 && game.PreviousNum == 11,msg);
            TestContext.Out.WriteLine(msg);
        }
        [Test]
        public void TestCountMovesLeft()
        {
            Game game = new();
            game.StartGame();
            game.HandleMove(game.Btns[1]);           
            int count = game.CountMovesLeft(10, game.Btns[9]);
            string msg = $"moves left = {count}, previous number = {game.PreviousNum}";
            Assert.That(count == 2 && game.PreviousNum == 2, msg);
            TestContext.Out.WriteLine(msg);
        }
    }
}
