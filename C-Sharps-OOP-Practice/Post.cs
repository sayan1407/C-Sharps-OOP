using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharps_OOP_Practice
{
    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        private int _totalvote;
        

        public Post(int id,string title,string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            CreatedDate = DateTime.Now;
            _totalvote = 0;
        }
        public int TotalVote
        {
            get
            {
                if (_totalvote <= 0)
                    return 0;
                else
                    return _totalvote;
            }
        }
        public void UpVote()
        {
            _totalvote++;
        }
        public void DownVote()
        {

            _totalvote--;
        }

    }
}
