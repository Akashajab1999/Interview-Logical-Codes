Console.WriteLine("Enter Your Number :");
int number =int.Parse(Console.ReadLine());
if(number%2==0 & number!=0){
    Console.WriteLine("Your Number is Even Number.");
}
 else if(number%2!=0){
    Console.WriteLine("Your Number is odd Number.");
}
else{
    Console.WriteLine("Your Number is neigther odd neigther even number.");
}
