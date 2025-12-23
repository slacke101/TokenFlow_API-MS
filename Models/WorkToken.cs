using System;


namespace TokenFlow_API_MS.Models
{
    public class WorkToken
    {
        public Guid tokenID { get; }
        public DateTime createdAt { get; }
        public string? tokenName { get; private set; }
        public string? tokenType { get; private set; }
        public string? tokenInfo { get; private set; }
        public string? createdBy { get; private set; }
        public string Priority { get; private set; } = "Medium";
        public DateTime dueDate { get; private set; }
        


      // constructor to set token details automatically when created 

        public WorkToken(string? tokenName, string? tokenInfo, string? tokenType, string? createdBy, DateTime? dueDate = null )
        {
            this.tokenID = Guid.NewGuid(); // here Guid is used to generate a unique ID
            this.tokenName = tokenName; // name of the token (ex. = " Finish New Hire Onboarding Feb")
            this.tokenInfo = tokenInfo; // holds the information of token "task"
            this.tokenType = tokenType; // tells user token type "task" or "request"
            this.createdAt = DateTime.UtcNow; // timestamp for token creation
            this.createdBy = createdBy; // displays creator of token
            this.dueDate = dueDate ?? DateTime.UtcNow; // uses passed value, fallback to now



        }

    }
}


