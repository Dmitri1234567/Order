using System;
using System.Collections.Generic;

namespace Order
{
    internal class Class1
    {
        private String cookingName;
        private String compound;
        private String cookingLastName;
        public String oreder;
        public int i = 0;
       

        private int countCompound;

        public List<String> Menu = new List<string>();
        public List<String> Compound1 = new List<string>();
       
      
        public void setCookingLastName(String cookingLastName)
        {
            this.cookingLastName = cookingLastName;
        }
        public String getCookingLastName()
        {
            return cookingLastName;
        }
      public void setCountCompound(int countCompound)
        {
            this.countCompound = countCompound;
        }
        public int getCountCompound()
        {
            return countCompound;
        }

        public void setCookingName(String cookingName)
        {
            this.cookingName = cookingName;
        }
        public String getCookingName()
        {
            return cookingName;
        }
        public void setCompound(String compound)
        {
            this.compound = compound;
        }
        public String getCompound()
        {
            return compound;
        }
    public void show()
        {
            foreach(string menu in Menu)
            {
                Console.WriteLine(menu);
            }
            foreach(string compound1 in Compound1)
            {
                Console.WriteLine(compound1);
            }
           
           
        }
       

        public void Order()
        {
           
            Console.WriteLine("Enter your order please");
            string order = Console.ReadLine();
            Console.WriteLine(order);
        




        }

    }
}
