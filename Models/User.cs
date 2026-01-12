using TokenFlow_API_MS.Models;

namespace TokenFlow_API_MS.Models
{
    public class User
    {
        public string UserID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<WorkToken> CurrentTokens { get; private set; }






        public void RemoveUser(string name)
        {



        }

        public void ReAssignUser(string name)
        {

        }


    }


}
