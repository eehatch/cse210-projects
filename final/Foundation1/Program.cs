class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Wicked | What Is This Feeling", "Wicked Movie", 3);
        Comment comment11 = new("First Last", "This is a comment found on a YouTube video");
        Comment comment12 = new("utopiaa_1775", "the book tapping in sync with “i don’t think i could” at 1:21 scratches my brain in a way only the operation mincemeat typewriter choreography has done before");
        Comment comment13 = new("usernumber64", "It’s unhealthy how many times I watched this.");


        video1.comments.Add(comment11);
        video1.comments.Add(comment12);
        video1.comments.Add(comment13);

        Video video2 = new Video("Trust in the Lord 2022 Youth Theme ASL","Janelle Nielsen", 4);
        Comment comment21 = new("richardclaro2163", "Very beautiful ladies");
        Comment comment22 = new("emmamolly7872","Looking through the comments, I see I'm not the only one that was expecting an advanced tutorial");
        Comment comment23 = new("ayaalbasha1414", "Who else is here because of tiktok.");


        video2.comments.Add(comment21);
        video2.comments.Add(comment22);
        video2.comments.Add(comment23);

        Video video3 = new Video("The Agricultural Revolution: Crash Course World History #1", "Crash Course", 4);
        Comment comment31 = new ("candacelord8143", "Alright guess I know what I’m doing during this quarantine");
        Comment comment32 = new ("ayaalbasha5644", "Who else is here because of online school.");
        Comment comment33 = new ("rigleywach913", "to all my fellow AP students, good luck on your test");

        video3.comments.Add(comment31);
        video3.comments.Add(comment32);
        video3.comments.Add(comment33);

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();
            video.ListComment();
            video.GetCommentCount();
            Console.WriteLine();
        }
    }
}