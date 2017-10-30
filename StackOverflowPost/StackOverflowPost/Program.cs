using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;
            Console.WriteLine("Welcome to StackOverflowPost, enter a title.");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter a description.");
            var input2 = Console.ReadLine();

            var post1 = new Post(input1, input2);

            Console.WriteLine("Commands: ViewPost, UpVote, DownVote, VoteCount, Exit");
            

            do
            {
                var input3 = Console.ReadLine();
                switch (input3)
                {
                    case "ViewPost":
                        Console.WriteLine("Title: {0}\nDescription: {1}\nCreated: {2}\nVoteCount: {3}", post1.Title, post1.Description, post1.CreatedAt, post1.VoteCount);
                        break;
                    case "UpVote":
                        post1.UpVote();
                        Console.WriteLine("+1");
                        break;
                    case "DownVote":
                        post1.DownVote();
                        Console.WriteLine("-1");
                        break;
                    case "VoteCount":
                        Console.WriteLine("Current Vote Count: " + post1.VoteCount);
                        break;
                    case "Exit":
                        isRunning = false;
                        break;
                }
            } while (isRunning);

        }
    }
}
