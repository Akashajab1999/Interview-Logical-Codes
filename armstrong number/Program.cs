int length = 0;
 int  order(int num){
   while(num!=0){
    length++;
    num/=10;
   } 

   return length;
}


bool armstrong(int num, int length){

    int sum = 0, temp, digit;
    temp = num;
    
    // loop to extract digit, find power & add to sum
    while(temp != 0)
    {
        // extract digit
        digit = temp % 10;

        // add power to sum
        sum = (int)(sum + Math.Pow(digit,length));
        temp /= 10;
    };

    return num == sum;
}


    //variables initialization
    int num = 477, len;
 
    // function to get order(length)
    len = order(num);
    
    // check if Armstrong
    if (armstrong(num, len))
        Console.WriteLine($"{num} is armstrong");
    else
         Console.WriteLine($"{num} is not  armstrong");

   