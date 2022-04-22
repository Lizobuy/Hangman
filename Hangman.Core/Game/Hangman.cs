using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        private string _guessProgress;
        private int _lives;
        

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {

            string[] words = { "animal", "bread", "peach", "shopping", "sugar", "movie", "telephone", "facebook",
                           "system", "science", "tiktok", "drink", "avocado", "chicken", "pizza",
                           "chocolate", "yogurt", "cheese", "penguin", "project" };

            Random random = new Random();
            var index = random.Next(0, 19);

            string GuessedWords = words[index];


            char[] guess = GuessedWords.ToCharArray();

            _lives = 6;


            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");


            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 17);

            Console.ForegroundColor = ConsoleColor.Green;



            for(int i = 0; i < guess.Length; i++)

            {
                _guessProgress += "*";
                Console.SetCursorPosition(0, 17);
            }

            while (_lives > 0)
            {

                _renderer.Render(5, 5, _lives);

                Console.SetCursorPosition(0, 17);

                char playerguess = char.Parse(Console.ReadLine());


                char[] guessProgressArray = _guessProgress.ToCharArray();
                

                bool correct = false;

                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == playerguess)
                    {
                        guessProgressArray[i] = guess[i];
                        correct = true;
                    }
                }
                _guessProgress = new string(guessProgressArray);
                Console.SetCursorPosition(0, 18);


                Console.WriteLine(_guessProgress);

                if (!correct)
                {
                    _lives--;
                    _renderer.Render(5, 5, _lives);


                }

            }

             Console.SetCursorPosition(2, 22);

            if (_lives > 0)
            {
                Console.WriteLine("you survived.");
            }
            else
            {
                Console.WriteLine("you died.");
                Console.WriteLine(guess);

            }

        }



    }
}
