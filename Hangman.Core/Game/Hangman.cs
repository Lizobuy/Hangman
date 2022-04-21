using System;
using HangmanRenderer.Renderer;


namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;

        string[] words = { "animal", "bread", "peach", "shopping", "sugar", "movie", "telephone", "facebook",
                           "system", "science", "tiktok", "drink", "avocado", "chicken", "pizza",
                           "chocolate", "yogurt", "cheese", "penguin", "project" };


        private string _guessProgress;
        private string _guessWord;
        private string _guess;
        private int _lives = 6;


        public HangmanGame()
        {
            _renderer = new GallowsRenderer();

            Random random = new Random();
            int index = random.Next(words.Length);


            for (int i = 0; i < _guessWord.Length; i++)
            {
                _guessProgress += "*";
            }
        }
        public class GuessingGame
        {
            public string _GuessingGame;
            private string _renderer;
            public string _guessWord;
            private int lives;

            public void Run()

            {
                _renderer.Render(5, 5, 6);

                Console.SetCursorPosition(0, 13);
                Console.ForegroundColor = ConsoleColor.Blue;

                while (lives > 0 && lives <=6)

                Console.Write("Your current guess: ");
                Console.WriteLine("--------------");
                Console.SetCursorPosition(0, 15);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("What is your next guess: ");
                var nextGuess = Console.ReadLine();
            }
        }



    }
}
















        