
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
                TokenName: "Complete WorkToken Model",
                TokenInfo: "Finish onboarding for the follwing",
                TokenType: "Task",
                CreatedBy: "Rafael A Castro",
                DueDate: new DateTime(2025, 12, 30, 12, 0, 0)

            );

            Console.WriteLine($"Token ID: {myToken.TokenID}");
            Console.WriteLine($"Created At: {myToken.CreatedAt}");
            Console.WriteLine($"Name: {myToken.TokenName}");
            Console.WriteLine($"Info: {myToken.TokenInfo}");
            Console.WriteLine($"Task Type: {myToken.TokenType}");
            Console.WriteLine($"Created By: {myToken.CreatedBy}");
            Console.WriteLine($"Priority: {myToken.Priority}");
            Console.WriteLine($"Due Date: {myToken.DueDate}");
        }

    }
}




