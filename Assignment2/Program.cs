using System;

namespace Assignment2
{

  class Array{
      int a;

      public Array(int n)
      {
          a=n;
          int[] numbers= new int[a];
          Console.WriteLine("enter the numbers");
        
          for(int i=0;i<a;i++){
              if(i<10){
              numbers[i]=int.Parse(Console.ReadLine());
              }
              else{
                  Console.WriteLine("Array crosses 10");
                  break;
              }
          }
      }

      
      }

  






    class Program
    {
        static void Main()
        {   
            Console.WriteLine("enter the size of array");
            int n=int.Parse(Console.ReadLine());
            Array a1=new Array(n);
            
            Console.WriteLine("Enter the length of sequence of fibonacci series");
            int length=int.Parse(Console.ReadLine());
            int t1=0;
            int t2=1;
            int t3=0;
            Console.WriteLine("---The Fibonacci Series---");
             Console.WriteLine(t1);
            Console.WriteLine(t2);
            for(int i=0;i<length-2;i++){
                t3 = t1 + t2;
                Console.WriteLine(t3);
                t1 = t2;
                t2 = t3;           

            }
        }
    }
}
