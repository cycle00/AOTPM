using System;
using System.Text;

namespace AOTPM {
    public class Program {
        public static string Name { get; private set; } = string.Empty;

        public static void Main(string[] args) {
            Console.WriteLine("Welcome to the story of the Attack of the Pig Monster!");
            Start();
        }

        private static void Start() {
            Console.WriteLine("Please input your name.");
            Name = Console.ReadLine();

            Console.WriteLine($"Welcome, {Name}, loading story...");
            Load();
        }

        private static void Load() {
            
        }
    }
}