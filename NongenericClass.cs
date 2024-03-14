using System;
using System.Collections;


namespace Ncit_Nishan
{
    

    class NongenericClass
    {
        static void Main()
        {
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);             
            arrayList.Add("Hello");       
            arrayList.Add(3.14);            
            arrayList.Add(true);            

            Console.WriteLine("ArrayList with mixed data types:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            
            ArrayList intList = new ArrayList();
            intList.Add(5);
            intList.Add(15);
            intList.Add(25);

            Console.WriteLine("\nArrayList with integers:");
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
        }
    }

}
