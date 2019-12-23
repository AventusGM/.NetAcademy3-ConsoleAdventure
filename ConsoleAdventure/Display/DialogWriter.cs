using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.NPC
{
    static class DialogWriter
    {
        public static string SpeakerName { get; set; }
        public static void Write(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(SpeakerName + ": ");
            Console.ResetColor();
            Console.WriteLine(Text);
            Console.WriteLine();
        }

        public static void WritePlayer(string Text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("PLAYERTODO: ");
            Console.ResetColor();
            Console.WriteLine(Text);
            Console.WriteLine();
        }

        public static void WriteResponses(List<DialogResponse> responses)
        {
            int i = 1;
            foreach(DialogResponse response in responses)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("[{0}]", i);
                Console.ResetColor();
                Console.WriteLine(" - " + response.ResponseText);
                i++;
            }
            Console.WriteLine();
        }
    }
}
