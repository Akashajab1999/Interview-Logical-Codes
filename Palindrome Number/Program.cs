Console.WriteLine("Enter your number");
int number = int.Parse(Console.ReadLine());
int reminder ,reverse =0;
int temp=number;
while(temp!=0){
 reminder= temp%10;
 reverse=reverse * 10 +reminder;
 temp=temp/10;

}


if(number==reverse){

    Console.WriteLine("Given number is Palindrome number");
}
else{
    Console.WriteLine("Given number is not Palindrome number");
}
