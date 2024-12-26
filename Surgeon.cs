public class Surgeon : HospitalStaff
{
    public Surgeon(string Name, int ID) : base(Name, ID)
    {
    }

    public override void Work()
    {
        Console.WriteLine("The surgeon is performing surgery!");
        }
}