using System;



//TO DEVELOPERS: A TOKEN IN THIS CASE IS A VIRTUAL WORK TICKET WHICH CONTAINS A GUID, TICKTE INFORMATION, DUE DATE, ETC. // 


namespace TokenFlow_API_MS.Models
{
    public class WorkToken  // this class represents what a token will contain, class members below
    {

        // CLASS MEMBERS INSIDE WORKTOKEN CLASS // 

        public Guid tokenID { get; }  // guid is part of the overall system for randomized id generation. // FIELD
        public DateTime createdAt { get; } // FIELD
        public string? tokenName { get; private set; } // FIELD
        public string? tokenType { get; private set; } // FIELD
        public string? tokenInfo { get; private set; } // FIELD 
        public User? AssignedUser { get; private set; }
        public TokenState currentState { get; private set; } = TokenState.Draft;

        public string? createdBy { get; private set; } // FIELD
        public string Priority { get; private set; } = "Medium";  //FIELD
        public DateTime dueDate { get; private set; }

        // public TokenState currentState { get; private set; } = TokenState.Draft;        


        // constructor to set token details automatically when created 

        public WorkToken(string? tokenName, string? tokenInfo, string? tokenType, string? createdBy, DateTime? dueDate = null)  // data details set once token is created , note tokenID & createdAt are not present in the parameters as they are automatically crated by generation and by user.
        {
            if (tokenName == null)
                tokenID = Guid.Empty;


            this.tokenID = Guid.NewGuid(); // here Guid is used to generate a unique ID
            this.tokenName = tokenName; // name of the token (ex. = " Finish New Hire Onboarding Feb")
            this.tokenInfo = tokenInfo; // holds the information of token "task"
            this.tokenType = tokenType; // tells user token type "task" or "request"
            this.createdAt = DateTime.UtcNow; // timestamp for token creation
            this.createdBy = createdBy; // displays creator of token
            this.dueDate = dueDate ?? DateTime.UtcNow; // uses passed value, fallback to now



        }

        // method for assignToken

        public void assignUser(User user)
        {
            if (user == null)
            {
                return;
            }


            if (AssignedUser != null)
            {
                return;
            }

            AssignedUser = user;

        }
        
        


        // method for updateState

        public void updateState(TokenState newState)

        {
            if (newState != null)
                return;
        }


    }
}


