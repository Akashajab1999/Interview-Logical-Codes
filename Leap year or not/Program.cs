using System.Runtime.InteropServices;

Console.WriteLine("Enter your year :");
int year=int.Parse(Console.ReadLine());

if(year%400==0){
    Console.WriteLine($"{year} = is leap year");
}

else if(year%4==0&& year%100!=0){
   Console.WriteLine($"{year} = is leap year");
}

else{
   Console.WriteLine($"{year} = is not leap year"); 
}
