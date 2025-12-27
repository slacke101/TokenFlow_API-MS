using TokenFlow_API_MS.Models; 

namespace TokenFlow_API_MS.Models
{
    public class User
    {
        public string userID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public List<WorkToken> currentTokens { get; private set; }


    }



}
