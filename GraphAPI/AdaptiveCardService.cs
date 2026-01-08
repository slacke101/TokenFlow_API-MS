///  Work Token is converted into an Adaptive Card JSON 
///  Then sent out via Teams, Outlook, or web page

using System;
using TokenFlow_API_MS.Models;
using System.Text.Json;
using System.Collections.Generic;


namespace TokenFlow_API_MS.GraphAPI
{
    public class AdaptiveCardService
    {
        // method creating work token card from token to json 

        public string CreateWorkTokenCard(WorkToken token)
        {
            if (token == null) throw new ArgumentNullException(nameof(token));

            var card = new
            {
                type = "AdaptiveCard",
                schema = "http://adaptivecards.io/schemas/adaptive-card.json",
                version = "1.5",
                body = new List<object>()
            };

            return JsonSerializer.Serialize(card); // ✅ must return
        }


        // method to d




    }
}
