using System;
using System.Collections;
using TokenFlow_API_MS.Models


//TO DEVELOPERS: A TOKEN IN THIS CASE IS A VIRTUAL WORK TICKET WHICH CONTAINS A GUID, TICKTE INFORMATION, DUE DATE, ETC. // 


namespace TokenFlow_API_MS.Models
{
    public class WorkToken  // this class represents what a token will contain, class members below
    {

        // CLASS MEMBERS INSIDE WORKTOKEN CLASS // 

        public Guid TokenID { get; }  // guid is part of the overall system for randomized id generation. // FIELD
        public DateTime CreatedAt { get; } // FIELD
        public string? TokenName { get; private set; } // FIELD
        public string? TokenType { get; private set; } // FIELD
        public string? TokenInfo { get; private set; } // FIELD 
        public User? AssignedUser { get; private set; }
        public TokenState CurrentState { get; private set; }

        public string? CreatedBy { get; private set; } // FIELD
        public string Priority { get; private set; } = "Medium";  //FIELD
        public DateTime DueDate { get; private set; }

        // public TokenState currentState { get; private set; } = TokenState.Draft;        


        // constructor to set token details automatically when created 

        public WorkToken(string? TokenName, string? TokenInfo, string? TokenType, string? CreatedBy, DateTime? DueDate = null)  // data details set once token is created , note tokenID & createdAt are not present in the parameters as they are automatically crated by generation and by user.
        {
            if (TokenName == null)
                TokenID = Guid.Empty;


            this.TokenID = Guid.NewGuid(); // here Guid is used to generate a unique ID
            this.TokenName = TokenName; // name of the token (ex. = " Finish New Hire Onboarding Feb")
            this.TokenInfo = TokenInfo; // holds the information of token "task"
            this.TokenType = TokenType; // tells user token type "task" or "request"
            this.CreatedAt = DateTime.UtcNow; // timestamp for token creation
            this.CreatedBy = CreatedBy; // displays creator of token
            this.DueDate = DueDate ?? DateTime.UtcNow; // uses passed value, fallback to now



        }

        // method for assignToken

        public void AssignUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            if (AssignedUser != null)
                throw new InvalidOperationException("Token has already been assigned.");

            AssignedUser = user;
            user.AddToken(this);
        }


        // method for updateState

        public void UpdateState(TokenState NewState)

        {
            CurrentState = NewState;
            if (NewState

        }

        public void MaxToken(WorkToken workToken)
        {
            if (workToken !=

        }

    }
}


