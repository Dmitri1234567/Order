using System;

namespace Order
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.setCookingName("John");
            Console.WriteLine(class1.getCookingName());
            class1.setCompound("Apple");
            Console.WriteLine(class1.getCompound());
            class1.Menu.Add("Pizza");
           


            class1.Menu.Add("Meat");
            class1.Menu.Add("Apple Pie");


            class1.Menu.Add("Ice cream");
          


            class1.Compound1.Add("sausages");
          


            class1.Compound1.Add("tomatoes");
          

     

            class1.Compound1.Add("Shrimps");
         

            class1.show();
            class1.Order();


           
           
        }
    }
}
