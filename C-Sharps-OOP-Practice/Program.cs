using System;



namespace C_Sharps_OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //StopWatch stopWatch = new StopWatch();
                //stopWatch.Start();
                //stopWatch.Stop();
                //Console.WriteLine(stopWatch.TimeDifference.TotalMilliseconds);
                var post = new Post(1, "SQL Create Table", "SQL query to create a table");
                post.UpVote();
                post.DownVote();
                post.DownVote();
                post.DownVote();
                post.UpVote();
                post.UpVote();
                post.UpVote();
                Console.WriteLine("Title : {0},Description : {1},  TotalVote : {2}",post.Title,post.Description,post.TotalVote);
                var post1 = new Post(2, "SQL Insert Table", "SQL query to insert to a table");
                post1.UpVote();
                post1.UpVote();
                post1.UpVote();
                post1.DownVote();
                Console.WriteLine("Title : {0},Description : {1},  TotalVote : {2}", post1.Title, post1.Description, post1.TotalVote);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
