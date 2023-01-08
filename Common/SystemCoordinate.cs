namespace Common;

    public static class SystemCoordinate
{
<<<<<<< HEAD

    public static int GetNumberFromUser()
    {
        bool Parsed = int.TryParse(Console.ReadLine(), out int number);
        
        if(Parsed)
        {
            return number;
        }
        else
        {
            return -1;
        }
    }
=======
>>>>>>> main
    public static int GetNumberOfQuarter(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }

        if (x < 0 && y > 0)
        {
            return 2;
        }
        if (x < 0 && y < 0)
        {
            return 3;
        }

        if (x > 0 && y < 0)
        {
            return 4;
        }
        return -1;
    }
}