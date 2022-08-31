using System;
using static System.Console;

namespace Adventure {
	public class Functions {
        public static void Narrator (string text)
        {
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Blue;
            WriteLine(text);
            ResetColor();
            ReadKey();
        }
        public static void Npc(string name, string text)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(name + ": \"" + text + "\"");
            ResetColor();
            ReadKey();
        }
        static void Command(string message)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine(message);
            ResetColor();
        }
        static void Text(string message)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(message);
            ResetColor();
        }
    }
}