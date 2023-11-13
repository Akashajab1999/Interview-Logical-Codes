

int firstNumber=0;
int secondNumber=1;
int sum =0;
int febonacciSeries(int level){
for(int i=2;i<level;i++){

   sum=firstNumber+secondNumber;
   firstNumber=secondNumber;
   secondNumber=sum;

    
}

return sum;
}

 Console.WriteLine( febonacciSeries(15));