Public class Breathing {

     Console.WriteLine("Welcome to the breathing activity!");

     Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. 
     Clear your mind and focus on your breathing.");

     //int session = Convert.ToInt32(Console.ReadLine());

     for (int i = 5; i > 0; i--)
     {
        Console.WriteLine("Get ready");
        Console.Write(.);
        Thread.Sleep(1000);
     }

     for (int a = 5; a > 0; a--)
     {
        Console.WriteLine("Breath in...");
        Console.Write(a);
        Thread.Sleep(1000);
     }

     Console.WriteLine("Welldone!!!!")

     for (int a = 5; a > 0; a--)
     {
        Console.Write(a);
        Thread.Sleep(1000);
     }

     Console.WriteLine("You have completed " + session + "seconds of the breathing activity. Keep up the good work.");


}