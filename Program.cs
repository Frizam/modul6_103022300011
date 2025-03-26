// See https://aka.ms/new-console-template for more information

using modul6_103022300011;

SayaTubeUser user = new SayaTubeUser("Frizam");

SayaTubeVideo[] video = { new SayaTubeVideo("Review Film Scream oleh Frizam") , //membuat objek baru
                          new SayaTubeVideo("Review Film Terminator oleh Frizam"),
                          new SayaTubeVideo("Review Film Iron Giant oleh Frizam"),
                          new SayaTubeVideo("Review Film Guardians of the Galaxy oleh Frizam"),
                          new SayaTubeVideo("Review Film Guardians of the Galaxy vol 2 oleh Frizam"),
                          new SayaTubeVideo("Review Film Guardians of the Galaxy vol 3 oleh Frizam"),
                          new SayaTubeVideo("Review Film Iron man oleh Frizam"),
                          new SayaTubeVideo("Review Film Iron 2 oleh Frizam"),
                          new SayaTubeVideo("Review Film Iron 3 oleh Frizam"),
                          new SayaTubeVideo("Review Film Avengers oleh Frizam")
};

for (int i = 0; i < video.Length; i++)
{
    video[i].IncreasePlayCount(100000);
}

for (int i = 0; i < video.Length; i++)
{
    video[i].PrintVideoDetails();
}

for (int i = 0; i < video.Length; i++) 
{
    user.AddVideo(video[i]);
}

user.printAllVideoPlayCount();
