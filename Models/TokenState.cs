namespace TokenFlow_API_MS.Models
{
    public enum tokenState
    {
        Draft,
        In_Progress, // in-progress state
        Pending, // pending state
        Approved, // approved state
        Rejected, // rejected state
        Revise,   // activated IF tokenName and tokenID are subjected for revision
        Completed // only if pending and approved are satisfied (conditions AND gate)
    }

    public class TokenState
    {
        public tokenState CurrentState { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public string? UpdatedBy { get; private set; }

        public TokenState(tokenState initialState = tokenState.Draft)
        {
            CurrentState = initialState;
            UpdatedAt = DateTime.UtcNow;
        }

        public void TransitionTo(tokenState newState, string updatedBy)
        {
            if (!CanTransitionTo(newState))
                throw new InvalidOperationException($"Cannot transition from {CurrentState} to {newState}");

            CurrentState = newState;
            UpdatedBy = updatedBy;
            UpdatedAt = DateTime.UtcNow;
        }

        private bool CanTransitionTo(tokenState newState)
        {
            return CurrentState switch
            {
                tokenState.Draft => newState == tokenState.In_Progress,
                tokenState.In_Progress => newState == tokenState.Pending,
                tokenState.Pending => newState == tokenState.Approved || newState == tokenState.Rejected,
                tokenState.Rejected => newState == tokenState.Revise,
                tokenState.Revise => newState == tokenState.In_Progress,
                tokenState.Approved => newState == tokenState.Completed,
                tokenState.Completed => false, // terminal state
                _ => false
            };
        }

        
    }
}