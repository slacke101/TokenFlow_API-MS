using System;

namespace TokenFlow_API_MS.Models
{
    public class WorkToken
    {
        public Guid tokenID { get; }
        public DateTime createdAt { get; }
        public string? tokenName { get; private set; }
        public string tokenType { get; private set; }
        public string? createdBy { get; private set; }
        public string Priority { get; private set; } = "Meduim";

      // constructor to set token details automatically when created 

        public WorkToken(string tokenName)
        {
            this.tokenID = Guid.NewGuid(); // here Guid is used to generate a unique ID
            this.createdAt = DateTime.UtcNow; // timestamp for token creation
            this.tokenName = tokenName; // name of the token (ex. = " Finish New Hire Onboarding Feb")

        }

    }
}


