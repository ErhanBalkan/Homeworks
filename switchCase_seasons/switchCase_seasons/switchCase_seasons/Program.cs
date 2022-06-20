namespace switchCase_seasons
{
    internal class Program
    {

        static string returnToDay(int day)
        {
            switch (day)
            {
                case 1:
                    return "Pazartesi - hafta içi";
                    break;
                case 2:
                    return "Salı - hafta içi";
                    break;
                case 3:
                    return "Çarşamba - hafta içi";
                    break;
                case 4:
                    return "Perşembe - hafta içi";
                    break;
                case 5:
                    return "Cuma - hafta içi";
                    break;
                case 6:
                    return "Cumartesi - haftasonu";
                    break;
                case 7:
                    return "Pazar - haftasonu";
                    break;
                default:
                    return "1 haftada sadece 7 gün vardır...";
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(returnToDay(2));

        }
    }
}