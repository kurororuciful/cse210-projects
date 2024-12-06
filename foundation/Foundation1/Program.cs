using System;

class Program
{
    static void Main(string[] args)
    {

        // ############## Video 1 ##############

        // CREATING VIDEO OBJECT 
        Video LittleManTate = new Video("Little Man Tate", "Orion Pictures", "5986");
        
        // CREATING COMMENT OBJECT 
        Comment LittleManTate1 = new Comment("Oliver", "I have always been searching for a model my child can replicate. I guess I found it from this movie. ");
        Comment LittleManTate2 = new Comment("Ruth Nagelesh", "I don't understand a thing. I was hoping that there is a local subtitle available. ");
        Comment LittleManTate3 = new Comment("Brown Lee", "As a sporty guy, I never thought that kids of this level can accelerate at their young age. Creation indeed is a wonder and I am hopeful that most of the kids will find this insipirational specially that we are now in the computer dispensation. ");

        // ADDING COMMENT TO VIDEO
        LittleManTate.videoComment.Add(LittleManTate1);
        LittleManTate.videoComment.Add(LittleManTate2);
        LittleManTate.videoComment.Add(LittleManTate3);
    



        // ############## Video 2 ##############

        // CREATING VIDEO OBJECT 
        Video MostRefreshingDesert = new Video("Most Refreshing Desert Ever", "Oasis VLOGs", "342");

        // CREATING COMMENT OBJECT 
        Comment MostRefreshingDesert1 = new Comment("Vice Ganda Official", "Kasinungalingan! This is nothing but a click-bait video clip! ");
        Comment MostRefreshingDesert2 = new Comment("Secret Guy Who Loves to Hate", "WHOA!!! Now that is refreshing! LOL ");
        Comment MostRefreshingDesert3 = new Comment("asdf1234", "Once upon a time, there was a story where they lived hapily ever aftrer! ");
        Comment MostRefreshingDesert4 = new Comment("Maris Anthony for Life", "Kaysa pumunta pa ako sa totoong disyerto, mas gugustuhin ko pang lunurin mo ako ng alab ng iyong pagmamahal... di na talaga ako nadala... ");
        Comment MostRefreshingDesert5 = new Comment("i am Legend", "I knew it... its a prank! ");

        // ADDING COMMENT TO VIDEO
        MostRefreshingDesert.videoComment.Add(MostRefreshingDesert1);
        MostRefreshingDesert.videoComment.Add(MostRefreshingDesert2);
        MostRefreshingDesert.videoComment.Add(MostRefreshingDesert3);
        MostRefreshingDesert.videoComment.Add(MostRefreshingDesert4);
        MostRefreshingDesert.videoComment.Add(MostRefreshingDesert5);



        // DISPLAY COMMENT COUNT PER VIDEO
        Comment.CommentCounter(LittleManTate.videoComment);
        Comment.CommentCounter(MostRefreshingDesert.videoComment);    
    }
}