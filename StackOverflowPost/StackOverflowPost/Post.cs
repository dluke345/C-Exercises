using System;
using System.Collections.Generic;
using System.Reflection;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; private set; }
        public int VoteCount { get; private set; }

        public Post(string title, string desc)
        {
            Title = title;
            Description = desc;
            CreatedAt = DateTime.Now;
        }


        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;    
        }
    }
}