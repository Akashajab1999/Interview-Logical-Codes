

int PowerOfNumber(int Base,int exponent){
  int power=1;
  for(int i=1;i<=exponent;i++){
    power=power * Base;

  }

  return power;

}


Console.WriteLine(PowerOfNumber(2,3));