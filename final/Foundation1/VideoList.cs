using System;


class VideoList
    {
    public List<Video> _videos = new List<Video>();
    public VideoList()
        {
            
        }
    public void ShowVideoList()

{
        Console.WriteLine("");
        Console.WriteLine("Videos");
        Console.WriteLine("");
        foreach(Video video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");

            int numComments = video.GetNumComments();
            Console.WriteLine($"Comments: ({numComments} total)");
            Console.WriteLine("");
            video.ShowComments();
            
            }
        }
}    
