
internal class Program
{
    static string statusOfLamps(bool lamp1, bool lamp2, bool lamp3)
    {
        if (lamp1 == true && lamp2 == true && lamp3 == true)
        {
            return "Bütün lambalar yanıyor.";
        }else if (lamp1 != true && lamp2 != true && lamp3 != true)
        {
            return "Bütün lambalar sönük.";
        }
        else
        {
            return "Bazı lambalar yanıyor.";
        }
    }
    static void Main(string[] args)
    {
        bool lamp1 = true;
        bool lamp2 = true;
        bool lamp3 = true;
        Console.WriteLine(statusOfLamps(lamp1,lamp2,lamp3));
    }
}
