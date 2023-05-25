using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_quiz_application
{
    class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            List<Question> questions = new List<Question>()
                        {
            new Question()
            {   
                Text = "What is the capital of yemen?",
                Options = new string[] { "London", "aden", "Rome", "sanaa" },
                CorrectAnswerIndex = 1
            },
            new Question()
            {
                Text = "What is the largest planet in our solar system?",
                Options = new string[] { "Jupiter", "Mars", "Earth", "Saturn" },
                CorrectAnswerIndex = 0
            },
            new Question()
            {
                Text = "Who painted the Mona Lisa?",
                Options = new string[] { "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh", "Michelangelo" },
                CorrectAnswerIndex = 0
            }
            // Add more questions here
        };

            int score = 0;

            foreach (Question question in questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter your answer (1-4): ");
                int userAnswerIndex;
                Console.ForegroundColor = ConsoleColor.Black;
                bool isValidAnswer = int.TryParse(Console.ReadLine(), out userAnswerIndex);

                if (!isValidAnswer || userAnswerIndex < 1 || userAnswerIndex > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid answer. Skipping to the next question.");
                    Console.WriteLine();
                    continue;
                }

                if (userAnswerIndex - 1 == question.CorrectAnswerIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct answer!");
                    
                    score++;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong answer!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Your final score: {score}/{questions.Count}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}
    
