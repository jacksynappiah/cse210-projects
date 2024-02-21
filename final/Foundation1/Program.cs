using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Mango Smoothie";
        video1._length = "200";
        video1._author = "Smoothie Chef";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Alexa Bliss";
        video1Comment1._commentText = "This looks so refreshing!";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Randy Orton";
        video1Comment2._commentText = "I'm definitely trying this recipe.";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Sasha Banks";
        video1Comment3._commentText = "I love mangoes! This is perfect.";


        Video video2 = new Video();
        video2._title = "Sunset Time-lapse";
        video2._length = "300";
        video2._author = "Nature Lover";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "John Doe";
        video2Comment1._commentText = "This is so calming!!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Jane Smith";
        video2Comment2._commentText = "Beautiful time-lapse!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Alice Johnson";
        video2Comment3._commentText = "I love your videos!";

        Video video3 = new Video();
        video3._title = "Mountain Hiking";
        video3._length = "240";
        video3._author = "Adventure Seeker";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "John Doe";
        video3Comment1._commentText = "This is so inspiring!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Jane Smith";
        video3Comment2._commentText = "Amazing views!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Alice Johnson";
        video3Comment3._commentText = "I love your adventures!";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Bob Williams";
        video3Comment4._commentText = "Keep exploring!";


        //add comments to list for each video 
        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        //add each video to videosList 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}