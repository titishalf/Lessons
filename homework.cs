﻿using System;

namespace employee {
   class salary {
       static void employees(float salary,float hours)
       {
         double hour;
         float salarry;

       }
      public double salary1;   
      public string emptype;  
      public double hour;  
      public double gross;  
   }
   class salarry {
      static void Main(string[] args) {
         salary emp1 = new salary();   
         string name; 
         double gross ; 
         double Netsalary ; 
         double Total;
         Console.WriteLine("Enter Employee name:");
         name=Console.ReadLine();
         Console.WriteLine("enter employee type");
         emp1.emptype = Console.ReadLine();
          if(emp1.emptype=="monthly")
          {
              Console.WriteLine("enter salary");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    gross=emp1.salary1-((emp1.salary1*18)/100);
                    Netsalary=gross-((gross*3)/100);
                    Console.WriteLine("Mr/Mrs {0}your net salary is {1}",name,Netsalary);
          }
          else if(emp1.emptype=="temporary")
          {
            Console.WriteLine("enter salary per hour");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter hours worked");
                    emp1.hour=Convert.ToDouble(Console.ReadLine());
                    Total=emp1.salary1*emp1.hour;
                    gross=Total-((Total*18)/100);
                    Console.WriteLine("Mr/Mrs {0}your net salary is {1}",name,gross);   
          }
          else if (emp1.emptype=="evening")
          {
         Console.WriteLine("enter salary per hour");
                    emp1.salary1=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter hours worked");
                    emp1.hour=Convert.ToDouble(Console.ReadLine());
                    Total=emp1.salary1*emp1.hour;
                    Netsalary=Total+((Total*0.15)/100);
                    gross=Netsalary-((Netsalary*18)/100);
                    Console.WriteLine("Mr/Mrs {0}your net salary is {1}",name,gross);     
          }
          else{
              Console.WriteLine("invalid employee type");
          }
         

         Console.ReadKey();
      }
   }
}