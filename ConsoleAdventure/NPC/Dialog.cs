using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.NPC
{
    // Work in progress
    public class Dialog
    {
        List<DialogResponse> Responses { get; set; }

        public Dialog(string verb, List<DialogResponse> responses)
        {
            Responses = responses;
            DialogWriter.Write(verb);
        }

        public void Activate()
        {

        }
    }

    public class DialogResponse
    {
        public readonly string ResponseText;
        public readonly Action Consequence;
        public DialogResponse(string responseText, Action consequence)
        {
            ResponseText = responseText;
            Consequence = consequence;
        }
    }
}
