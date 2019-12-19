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
            Console.WriteLine(Text);
        }

        public static void WriteResponses(List<DialogResponse> responses)
        {
            int i = 1;
            foreach(DialogResponse response in responses)
            {
                Console.WriteLine("[{0}] - {1}", i, response.ResponseText);
                i++;
            }
        }
    }
}
