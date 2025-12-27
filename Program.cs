
using TokenFlow_API_MS;
using System;
using TokenFlow_API_MS.Models; // project name + directory (models)


namespace TokenFlow_API_MS
{
    public class Program
    {










        static void Main(string[] args) // 
        {
            // create a work token INSTANTIATE 
            WorkToken myToken = new WorkToken(                // always use the name of class and give the instantiate a name in this case myToken and create a new token using "new"
                tokenName: "Complete WorkToken Model",
                tokenInfo: "Finish onboarding for the follwing",
                tokenType: "Task",
                createdBy: "Rafael A Castro",
                dueDate: new DateTime(2025, 12, 30, 12, 0, 0)
                
             );

            Console.WriteLine($"Token ID: {myToken.tokenID}");
            Console.WriteLine($"Created At: {myToken.createdAt}");
            Console.WriteLine($"Name: {myToken.tokenName}");
            Console.WriteLine($"Info: {myToken.tokenInfo}");
            Console.WriteLine($"Task Type: {myToken.tokenType}");
            Console.WriteLine($"Created By: {myToken.createdBy}");
            Console.WriteLine($"Priority: {myToken.Priority}");
            Console.WriteLine($"Due Date: {myToken.dueDate}");
        }

    }
}




