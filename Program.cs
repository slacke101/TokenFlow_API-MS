using System;
using AdaptiveCards;
using AdaptiveCards.Rendering.Wpf;
using System.Windows;

namespace TokenFlow_API_MS
{
    public class Program
    {
        [STAThread] // required for WPF
        static void Main(string[] args)
        {
            // 1️⃣ Create your WorkToken
            var myToken = new WorkToken(
                TokenName: "Complete WorkToken Model",
                TokenInfo: "Finish onboarding for the following",
                TokenType: "Task",
                CreatedBy: "Rafael A Castro",
                DueDate: new DateTime(2025, 12, 30, 12, 0, 0)
            );

            // 2️⃣ Build Adaptive Card using SDK
            var card = new AdaptiveCard(new AdaptiveSchemaVersion(1, 5))
            {
                Body =
                {
                    new AdaptiveTextBlock("Work Token Details")
                    {
                        Weight = AdaptiveTextWeight.Bolder,
                        Size = AdaptiveTextSize.Large
                    },
                    new AdaptiveFactSet
                    {
                        Facts =
                        {
                            new AdaptiveFact("Token", myToken.TokenID.ToString()),
                            new AdaptiveFact("Issuer Name", myToken.CreatedBy),
                            new AdaptiveFact("Created At", myToken.CreatedAt.ToString("yyyy-MM-dd HH:mm")),
                            new AdaptiveFact("Due Date", myToken.DueDate.ToString("yyyy-MM-dd")),
                            new AdaptiveFact("Info", myToken.TokenInfo),
                            new AdaptiveFact("Priority", myToken.Priority)
                        }
                    }
                },
                Actions =
                {
                    new AdaptiveSubmitAction { Title = "Approve", Data = new { action = "approve" } },
                    new AdaptiveSubmitAction { Title = "Reject", Data = new { action = "reject" } }
                }
            };

            // 3️⃣ Render in WPF window
            var renderer = new AdaptiveCardRenderer();
            var frameworkElement = renderer.RenderCard(card);

            var window = new Window
            {
                Title = "Work Token Card",
                Content = frameworkElement,
                Width = 400,
                Height = 600
            };

            var app = new Application();
            app.Run(window);
        }
    }
}
