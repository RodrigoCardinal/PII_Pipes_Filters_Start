using System;
namespace CompAndDel;

//Ejercico 3
public class TwitterMessage
{
    public void Send (string path)
    {
        var twitter = new TwitterPicture();
        Console.WriteLine(twitter.PublishOnTwitter("text", path));
    }
}