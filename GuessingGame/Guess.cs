using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Guess
    {
        public int UserGuessNum { get; }
        public DateTime GuessTime { get; }


        //Constructor
        public Guess(int UserGuess)
        {
            UserGuessNum = UserGuess;
            GuessTime = DateTime.Now;
        }

    }
}
