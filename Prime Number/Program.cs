bool IsPrime(int number){
    bool status=true;
    if(number<2){
        status=false;
       return status; 
    }

    for(int i=2;i<number;i++){
        if(number%i==0){
            status=false;
            return status;
        }
    }
    return status;
}

 Console.WriteLine("Enter your Number :");
 int number =int.Parse(Console.ReadLine());
 if(IsPrime(number)){
    Console.WriteLine("Given Number is Prime Number");
 }

 else{
    Console.WriteLine("Not prime number");
 }


