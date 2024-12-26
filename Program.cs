using System;

class Program{

    public static void Main(string[] args){

        HospitalStaff[] HS = new HospitalStaff[3];
        Doctor d = new Doctor("yasir",101);
        Nurse n = new Nurse ("nada",102);
        Surgeon s = new Surgeon ("maher",103);

        HS[0]=d;
        HS[1]=n;
        HS[2]=s;

        HS[0].Work();
        HS[1].Work();
        HS[2].Work();
        
        Console.WriteLine("Doctor ID: "+ HS[0].GetID()); 
        Console.WriteLine("Nurse ID: "+ HS[1].GetID()); 
        Console.WriteLine("Surgeon ID: "+ HS[2].GetID()); 
      

        Console.WriteLine("total number of staff members is "+HospitalStaff.TotalStaff);
        
    }
}

