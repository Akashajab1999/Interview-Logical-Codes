Console.WriteLine("Enter your Number :");
int number =int.Parse(Console.ReadLine());
int reminder=0;
int sum =0;
while(number!=0){
    reminder=number%10;
    sum+=reminder;
    number=number/10;
}

Console.WriteLine($"Sum of digits = {sum}");
