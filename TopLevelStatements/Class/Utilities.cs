using System;
using System.Threading.Tasks;

namespace MyNamespace
{
    public static class Utilities
    {
        public static async Task ShowConsoleAnimation()
        {
            foreach (string s in new[] { "| -", "/ \\", "- |", "\\ /", })
            {
                Console.Write(s);
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
        }
    }
}