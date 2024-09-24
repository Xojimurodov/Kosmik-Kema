
class Program 
{
    public static void Main()
    {
        //Kosmik Kema.

        Console.Write("Kirish: ");
        string kardinata = Console.ReadLine()!;

        MySpaceship(kardinata);
    }

    private static void MySpaceship(string kardinata)
    {
        Spaceship spaceship = new Spaceship();
        
        for(int i = 0; i < kardinata.Length; i++)
        {
            if(kardinata[i] == 'R' && spaceship.Direction == "yuqori")
            {
                spaceship.Direction = "o'ng";
            }
            else if(kardinata[i] == 'R' && spaceship.Direction == "o'ng")
            {
                spaceship.Direction = "past";
            }
            else if(kardinata[i] == 'R' && spaceship.Direction == "past")
            {
                spaceship.Direction = "chap";
            }
            else if(kardinata[i] == 'R' && spaceship.Direction == "chap")
            {
                spaceship.Direction = "yuqori";
            }

            if(kardinata[i] == 'L' && spaceship.Direction == "yuqori")
            {
                spaceship.Direction = "chap";
            }
            else if(kardinata[i] == 'L' && spaceship.Direction == "chap")
            {
                spaceship.Direction = "past";
            }
            else if(kardinata[i] == 'L' && spaceship.Direction == "past")
            {
                spaceship.Direction = "o'ng";
            }
            else if(kardinata[i] == 'L' && spaceship.Direction == "o'ng")
            {
                spaceship.Direction = "yuqori";
            }
            
            if(kardinata[i] == 'A' && spaceship.Direction == "yuqori")
            {
                spaceship.Y--;
            }
            else if(kardinata[i] == 'A' && spaceship.Direction == "past")
            {
                spaceship.Y++;
            }
            else if(kardinata[i] == 'A' && spaceship.Direction == "o'ng")
            {
                spaceship.X++;
            }
            else if(kardinata[i] == 'A' && spaceship.Direction == "chap")
            {
                spaceship.X--;
            }
        }

        Console.WriteLine($"Qaytish qaytimi: x: {spaceship.X} y: {spaceship.Y} Dorection: {spaceship.Direction}");
    }
}