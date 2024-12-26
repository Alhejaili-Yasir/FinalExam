public class Doctor : HospitalStaff
{
    public Doctor(string Name, int ID) : base(Name, ID)
    {
    }
    public string Specialization{get; set;}

    public override void Work(){
        Console.WriteLine("The doctor is diagnosing patients!");
    }


}