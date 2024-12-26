public class Nurse : HospitalStaff{
    public Nurse(string Name, int ID) : base(Name, ID)
    {
    }
    public bool Shift{get; set;}

    public override void Work(){
        Console.WriteLine("The nurse is assisting patients!");

    }
}