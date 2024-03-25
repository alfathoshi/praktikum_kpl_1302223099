using modul6_1302223099;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Bintang");
        SayaTubeVideo[] video =
        {
            new SayaTubeVideo("Avengers: Infinity War"),
            new SayaTubeVideo("SpiderMan: No Way Home"),
            new SayaTubeVideo("Your Name"),
            new SayaTubeVideo("Silent Voice"),
            new SayaTubeVideo("Exhuma"),
            new SayaTubeVideo("The Greatest Showman"),
            new SayaTubeVideo("Hachiko: The Dog Story"),
            new SayaTubeVideo("Ready Player One"),
            new SayaTubeVideo("Top Gun: Maverick"),
            new SayaTubeVideo("Weathering With You"),
        };

        for (int i = 0; i < video.Length; i++)
        {
            user.AddVideo(video[i]);
        }
        user.PrintAllVideoPlayCount();
    }
}