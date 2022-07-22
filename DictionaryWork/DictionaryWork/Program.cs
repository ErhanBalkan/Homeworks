namespace dictionaryWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1,"Erhan","Balkan");
            Person p2 = new Person(2,"Mehmet","Taşkın");
            Person p3 = new Person(3,"Atilla","Canbaz");
            PersonManager pm = new PersonManager();
            pm.addPerson(p1.ID,p1);
            pm.addPerson(p2.ID,p2);
            pm.addPerson(p3.ID,p3);

            pm.deletePerson(2);
            pm.deletePerson(3);

       


        }
    }
}