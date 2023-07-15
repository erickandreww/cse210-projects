// program iterate through the list of videos 
// and for each one, display the title, author, 
// length, number of comments (from the method) 
// and then list out all of the comments for 
// that video. 

// Repeat this display for each video in the list.

using System;

class Program
{
    public static void Main(string[] args)
    {

        // Video 1
        Video video1 = new Video();
        video1._title = "10 Must-Read Books of All Time";
        video1._description = "Uncover 10 timeless books that have left an indelible mark on literature and are a must-read for every bookworm.";
        video1._videoLenght = 274; 

        // video 2
        Video video2 = new Video();
        video2._title = "10 Life Hacks for Everyday Tasks";
        video2._description = "Discover 10 practical life hacks to simplify your daily routine and make your tasks easier.";
        video2._videoLenght = 335; 

        // video 3
        Video video3 = new Video();
        video3._title = "7 Essential Photography Tips for Beginners";
        video3._description = "Master the basics of photography with 7 essential tips to enhance your skills and capture stunning shots.";
        video3._videoLenght = 186; 

        // video 4
        Video video4 = new Video();
        video4._title = "Top 5 Healthy Recipes for Weight Loss";
        video4._description = "Explore 5 delicious and nutritious recipes designed to support your weight loss journey.";
        video4._videoLenght = 425; 

        // Comments video 1
        List<List<string>> commentsVideo1 = new List<List<string>>() {
            new List<string> {"Sarah", "I love how diverse this list is, covering various genres and time periods. I'm excited to dive into these books!"}, 
            new List<string> {"Sam", "I'm an avid reader, and I've only read a few of these books. I'm definitely adding the rest to my reading list!"}, 
            new List<string> {"Ricardo",   "Books have always been my escape, and this video just gave me more reasons to explore new literary treasures. Amazing recommendations!"}
        };
        // Add comments
        foreach (List<string> comment in commentsVideo1) {
            Comment videoComment = new Comment();
            videoComment._personName = comment[0];
            videoComment._personComment = comment[1];
            video1._commentsList.Add(videoComment.AddComment());
        }
        
        // Comments video 2
        List<List<string>> commentsVideo2 = new List<List<string>>() {
            new List<string> {"John", "Thanks for sharing these useful tips. They will definitely make my life easier."}, 
            new List<string> {"Mathew",  "Wow, these life hacks are amazing! I can't wait to try them out!"}, 
            new List<string> {"Lara",  "I love watching life hack videos. They always inspire me to be more efficient and creative."}, 
            new List<string> {"Mary", "I've seen a few of these hacks before, but there are some new ones that I haven't tried. Great video!"}
        };
        // Add comments
        foreach (List<string> comment in commentsVideo2) {
            Comment videoComment = new Comment();
            videoComment._personName = comment[0];
            videoComment._personComment = comment[1];
            video2._commentsList.Add(videoComment.AddComment());
        }
        // Add comments
        // Comments video 3
        List<List<string>> commentsVideo3 = new List<List<string>>() {
            new List<string> {"Daniel", "These tips have improved my photography skills so much! Can't wait to try them out during my next photoshoot."}, 
            new List<string> {"Rebecca", "I just got a new camera, and these tips are exactly what I needed to kickstart my photography journey. Thanks!"},
            new List<string> {"Donald", "I've been interested in photography for a while now, and these tips are incredibly helpful. You explained them so well!"}
        };

        foreach (List<string> comment in commentsVideo3) {
            Comment videoComment = new Comment();
            videoComment._personName = comment[0];
            videoComment._personComment = comment[1];
            video3._commentsList.Add(videoComment.AddComment());
        }

        // Comments video 4
        List<List<string>> commentsVideo4 = new List<List<string>>() {
            new List<string> {"Luna", "As someone who is trying to lose weight, these recipes are exactly what I needed. Thank you for sharing!"}, 
            new List<string> {"Andrew", "These recipes look delicious and healthy. I'm definitely going to incorporate them into my diet."},
            new List<string> {"Illyana", "I've tried a few of these recipes before, and they are absolutely amazing. Can't wait to try the rest!"},
            new List<string> {"Erick", "I appreciate that these recipes are not only healthy but also easy to make. Great video!"}
        };

        foreach (List<string> comment in commentsVideo4) {
            Comment videoComment = new Comment();
            videoComment._personName = comment[0];
            videoComment._personComment = comment[1];
            video4._commentsList.Add(videoComment.AddComment());
        }


        // Display all videos
        video1.Display();
        video2.Display();
        video3.Display();
        video4.Display();
    }
}