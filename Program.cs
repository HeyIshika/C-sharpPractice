using System;

namespace Assign1
{
    class Program
    {
        static void Main()
        {
             Console.WriteLine("Enter the no. of names:");
            int n= int.Parse(Console.ReadLine());
            //Enter the names//
            string[] names=new string[n];
            for(int i=0;i<n;i++){
               names[i]=Console.ReadLine();//scanf
            }
            //displaying the names
             for(int i=0;i<n;i++){
               Console.WriteLine("names[{0}]:{1}" , i , names[i]);
            }
            //searching a name

             
             Console.WriteLine("Enter the name you want to search");
             string strname=Console.ReadLine();
             int flag=0;
             for(int i=0;i<n;i++){
                 if(strname==names[i]){
                     Console.WriteLine("Found the name at {0}" , i);
                     flag=1;
                     break;
                     
                 }
                 
             }
             if(flag==0){
             Console.WriteLine("Name not Found");
             }

             //copy the array in new  array
             
             string[] dictionary ;
             dictionary = new string[n];
             names.CopyTo( dictionary, 0 );
             Console.WriteLine("Copied List of Names in Dictionary");
             for(int i=0;i<n;i++){
                 Console.WriteLine(dictionary[i]);
             }
             //Sorting the array.
             Console.WriteLine("Sorted List of Names");
             
             Array.Sort(dictionary);
             for(int i=0;i<n;i++){
             Console.WriteLine(dictionary[i]);
             }




        }
    }
}
