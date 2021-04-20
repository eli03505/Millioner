using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] millionaire)
        {
            Console.Title = "Question\n";
            GetData(out string[] questions, out string[][] answers);
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                var randomAnswers = Random(answers[i]);
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(questions[i]);
                PrintAnswers(randomAnswers);
                uint answerIndex;
                while (true)
                {
                    Console.Write("Your answer: ");
                    var answer = Console.ReadLine();
                    answerIndex = Random(answer);
                    if (answerIndex >= 0) { 
                        break;
                        Console.WriteLine("Please, input correct answer!");
                    }
                }
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(questions[i]);
                if (randomAnswers[answerIndex] == randomAnswers[3])
                {
                    CorrectAnswer(randomAnswers);
                }
                Console.WriteLine("The answer is wrong");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void GetData(out string[] question, out string[][] reply)
        {
            const int questionsCount = 10;
            question = new string[questionsCount];
            reply = new string[questionsCount][];
            question[0] = "C# class can inherit multiple_____";
            reply[0] = new string[4];
            reply[0][0] = "Classes";
            reply[0][1] = "Interfaces";
            reply[0][2] = "Abstract classes";
            reply[0][3] = reply[0][1];

            question[1] = "Which of the followings are value types in C#?";
            reply[1] = new string[4];
            reply[1][0] = "Int32";
            reply[1][1] = "Double";
            reply[1][2] = "All of the above";
            reply[1][3] = reply[1][2];

            question[2] = "Which of the following is a reference type in C#?";
            reply[2] = new string[4];
            reply[2][0] = "String";
            reply[2][1] = "Long";
            reply[2][2] = "Boolean";
            reply[2][3] = reply[2][0];

            question[3] = "Which of the following datatype can be used with enum?";
            reply[3] = new string[4];
            reply[3][0] = "Int";
            reply[3][1] = "String";
            reply[3][2] = "Result";
            reply[3][3] = reply[3][0];

            question[4] = "String data type is ______.";
            reply[4] = new string[4];
            reply[4][0] = "Mutable";
            reply[4][1] = "Immutable";
            reply[4][2] = "Static";
            reply[4][3] = reply[4][1];

            question[5] = "Func and Action are the types of ______";
            reply[5] = new string[4];
            reply[5][0] = "Delegate";
            reply[5][1] = "Event";
            reply[5][2] = "Utility function";
            reply[5][3] = reply[5][0];

            question[6] = "A partial class allows ________";
            reply[6] = new string[4];
            reply[6][0] = "Implementation of single class in multiple .cs files.";
            reply[6][1] = "Multiple class inheritance.";
            reply[6][2] = "Declaration of multiple classes in a single .cs file.";
            reply[6][3] = reply[6][2];

            question[7] = "What is Nullable type?";
            reply[7] = new string[4];
            reply[7][0] = "It allows assignment of null to value type.";
            reply[7][1] = "It allows assignment of null to static class.";
            reply[7][2] = "None of the above.";
            reply[7][3] = reply[7][0];

            question[8] = "CLR stands for __________";
            reply[8] = new string[4];
            reply[8][0] = "Common Local Runtime";
            reply[8][1] = "Common Language Runtime";
            reply[8][2] = "Common Language Realtime";
            reply[8][3] = reply[8][0];

            question[9] = "CLR is responsible for";
            reply[9] = new string[4];
            reply[9][0] = "Garbage Collection";
            reply[9][1] = "All of the above";
            reply[9][2] = "Code Verification";
            reply[9][3] = reply[9][1];
        }
        public static void PrintAnswers(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {answers[i]}");
            }
        }
        public static uint Random(string answer)
        {
            if (!String.IsNullOrWhiteSpace(answer))
            {
                char variant = (char)(answer.ToUpper().ToCharArray()[0]);
                if (variant.Equals('A') || variant.Equals(('B')) || variant.Equals('C'))
                {
                    return (uint)(variant-65);
                }
            }
            return 0;
        }
        public static void WrongAnswer(string[] answers, short wrongAnswer)
        {
            for (int i = 0; i < 3; i++)
            {
                if (answers[i] == answers[3])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ResetColor();
                    continue;
                }
                else if (i == wrongAnswer)
                {
                    continue;
                }
            }
        }
        public static void CorrectAnswer(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {
                if (answers[i] != answers[3])
                {
                    Console.WriteLine($" {answers[i]}");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {answers[i]}");

                Console.ResetColor();
            }
        }
        public static string[] Random(string[] answers)
        {
            var random = new Random();
            var randomAnswers = new string[4];
            var numbers = String.Empty;
            var counter = 0;
            while (counter < 3)
            {
                var index = random.Next(0, 3);
                if (!numbers.Contains(index.ToString()))
                {
                    numbers += index.ToString();
                    randomAnswers[index] = answers[counter];
                    counter++;
                }
            }
            randomAnswers[3] = answers[3];
            return randomAnswers;

            Console.ReadKey();
        }
    }
}