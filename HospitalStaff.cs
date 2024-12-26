using System;

public class HospitalStaff {
    public string Name {get; set;}
    private int ID {get; set;}

    public static int TotalStaff;

    public HospitalStaff(string Name, int ID)
    {
        this.Name = Name;
        this.ID = ID;
        TotalStaff++;
    }

    public virtual void Work()
    {
        Console.WriteLine("The staff member is working!");
    }

    public int  GetID()
    {
         return ID; 
    }





}