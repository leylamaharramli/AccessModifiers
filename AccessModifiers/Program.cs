namespace AccessModifiers
{
    public class Program
    {
        static void Main()
        {
            Singer singer1 = new Singer();
            singer1.Limit("Muslum", "Gurses", 74);

            Song song = new Song();
            song.Max("Affet", "Pop", singer1);



            song.AddRating(1);
            song.AddRating(7);
            song.AddRating(9);
            song.AddRating(5);


            song.GetAverageRating();
        }
    }
}
