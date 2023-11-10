Console.WriteLine("Enter Your Number:");
int number1=int.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Operator:");
char op=char.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Number:");
int number2=int.Parse(Console.ReadLine());
double result=0;
switch(op){
    case '+':
    result= number1 + number2;
    break;
    case '-':
    result= number1 - number2;
    break;
    case '*':
    result =number1* number2;
    break;
    case '/':
    result =number1 / number2;
    break;
}
Console.WriteLine(result);
