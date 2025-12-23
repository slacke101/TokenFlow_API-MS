
using TokenFlow_API_MS;
using System;
using TokenFlow_API_MS.Models;

namespace TokenFlow_API_MS
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create a work token 
            WorkToken myToken = new WorkToken(
                tokenName: "Complete WorkToken Model",
                tokenInfo: "Ensure that the work token model for our TokenFlow system is completed using C# ASP.NET Core",
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
