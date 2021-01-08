using System;
using System.Collections.Generic;

namespace SourceScout.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int UpVotes { get; set; } = 1;
        public int DownVotes { get; set; }
        public double Score { get; set; }
        public string Thumbnail { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public bool Deleted { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<PostTag> Tags { get; set; }
        
    }
}
