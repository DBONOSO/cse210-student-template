using System;

class Program
{
    static void Main(string[] args)
    {
        VideoList videoList = new VideoList();
        Video video1 = new Video("Messi the best player of all time","David Bonoso", 120);
        videoList._videos.Add(video1);
        Comment comment1 = new Comment("You got it", "Leonel Messi");
        Comment comment2 = new Comment("Awesome", "TYC");
        Comment comment3 = new Comment("Messi <3", "Futbolibre");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        Video video2 = new Video("Come follow me", "Pepemormon", 132);
        videoList._videos.Add(video2);
        Comment comment4 = new Comment("This is my favorite lesson", "MartinAc");
        Comment comment5 = new Comment("It help me to be better", "Juanbop");
        Comment comment6 = new Comment("I learned a lot with this program", "Sud123");
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        Video video3 = new Video("The best NBA players", "NBA123", 23);
        videoList._videos.Add(video3);
        Comment comment7 = new Comment("Jordan is the best", "Drake.");
        Comment comment8 = new Comment("Kobe Bryant <3", "LakersU");
        Comment comment9 = new Comment("Thanks for your video", "Thankss");
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        videoList.ShowVideoList();

    }
}