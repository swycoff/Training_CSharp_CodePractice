using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate {
    class Post {
        private string title;
        private string description;
        private DateTime createdDate;
        private int vote;

        public Post(string title, string description) {
            this.title = title;
            this.description = description;
            createdDate = DateTime.Now;
        }
        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public DateTime dateTime { get { return createdDate; } }
        public int Vote { get { return vote; } }

        public int UpVote() {
            vote++;
            int test = vote;
            return vote;
        }
        public int DownVote() {
            vote--;
            return vote;
        }
       

        //Main method
        //create a post
        //up vote and down vote it a few times
        //show current value of votes


    }
}
