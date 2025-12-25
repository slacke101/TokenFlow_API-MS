namespace TokenFlow_API_MS.Models
{
    public enum tokenState
    {
        Draft,      // task draft
        In_Progress, // in-progress state
        Pending, // pending state
        Approved, // approved state
        Rejected, // rejected state
        Revise,   // activated IF tokenName and tokenID are subjected for revision
        Completed // only if pending and approved are satisfied (conditions AND gate)
    }

    public class TokenState
    {
    }
}
