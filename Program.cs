// Program.cs — uden raw string literal (løser CS8999)
using System;
using System.Collections.Generic;

namespace SparePartsInventoryAssistant;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine(AssistantData.Greeting);

        bool partAvailable = false;
        while (!partAvailable)
        {
            Console.Write(AssistantData.Question + " ");
            var line = Console.ReadLine();

            if (line is null) break; // EOF (Ctrl-D/Ctrl-Z)

            if (AssistantData.Parts.Contains(line))
            {
                Console.WriteLine(string.Format(AssistantData.ReplyPositive, line));
                partAvailable = true;
            }
            else if (AssistantData.UserQuestions.Contains(line))
            {
                Console.WriteLine(
                    string.Format(AssistantData.ReplyNumberOfParts, AssistantData.Parts.Count)
                    + "\n" + string.Join("\n", AssistantData.Parts)
                );
            }
            else
            {
                Console.WriteLine(string.Format(AssistantData.ReplyNegative, line));
            }
        }
    }
}

internal static class AssistantData
{
    public static readonly List<string> Parts = new()
    {
        "hydraulic pump",
        "PLC module",
        "servo motor"
    };

    public const string Greeting = "Hej. Welcome to the spare parts inventory!";
    public const string Question = "Which part do you need?";
    public const string ReplyPositive = "I've got {0} here for you 😊. Bye!";
    public const string ReplyNegative = "I am afraid we don’t have any {0} in the inventory";
    public const string ReplyNumberOfParts = "We have {0} part(s)!";

    public static readonly List<string> UserQuestions = new()
    {
        "Do you actually have any parts?",
        "Is there anything in stock at all?",
    };
}