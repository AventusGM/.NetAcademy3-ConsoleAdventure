using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.NPC
{
    public class Dialog
    {
        List<DialogResponse> Responses { get; set; }
        string InitialVerb;

        public Dialog(string verb, List<DialogResponse> responses)
        {
            Responses = responses;
            InitialVerb = verb;
        }

        public void Activate()
        {
            DialogWriter.Write(InitialVerb);
            ResponseHandler.HandleResponses(Responses);
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

    internal class ResponseHandler
    {
        public static void HandleResponses(List<DialogResponse> responses)
        {
            DialogWriter.WriteResponses(responses);

        ReadResponse:
            int responseIndex = (int)char.GetNumericValue(Console.ReadKey().KeyChar)-1;
            if(responseIndex != null && responseIndex >= 0 && responseIndex < responses.Count )
            {
                DialogWriter.WritePlayer(responses[responseIndex].ResponseText);
                if(responses[responseIndex].Consequence != null)
                {
                    responses[responseIndex].Consequence.Invoke();
                }
            }
            else
            {
                goto ReadResponse;
            }
        }
    }
}
