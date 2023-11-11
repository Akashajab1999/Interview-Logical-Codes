Console.WriteLine("Enter Your Number:");
float number1=float.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Operator:");
char op=char.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Number:");
float number2=float.Parse(Console.ReadLine());
float result=0;
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
