using System;
namespace Assignment_3
{
	public class RobotFightingGame
	{
		public bool GameOver { get; set; }
        public string Winner { get; set; }

        public Robot FirstContestant { get; }
        public Robot SecondContestant { get; }

        public RobotFightingGame(Robot firstContestant, Robot secondContestant)
		{
            FirstContestant = firstContestant;
            SecondContestant = secondContestant;
        }

        public void NextRound()
        {
            FirstContestant.Attack(SecondContestant);
            SecondContestant.Attack(FirstContestant);

            GameOver = FirstContestant.Health <= 0 || SecondContestant.Health <= 0;

            if (FirstContestant.Health > 0 && SecondContestant.Health <= 0)
            {
                Winner = FirstContestant.Name;
            }

            if (SecondContestant.Health > 0 && FirstContestant.Health <= 0)
            {
                Winner = SecondContestant.Name;
            }
        }
    }
}

