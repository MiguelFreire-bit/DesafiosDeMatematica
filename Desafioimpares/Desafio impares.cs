using System; 

class minhaClasse {

        public static void Main()
        {
            int i = 0;
            int x = 0;
            
            while (x > 1000 || x < 1)
            {
                x = int.Parse(Console.ReadLine());
            }
                //complete seu codigo
            for (i = 0; i<= x; i++) 
            {
                if(i % 2 != 0)
                {
                Console.WriteLine($" {i}");
                }
            }
                
            Console.ReadLine();
        }

}