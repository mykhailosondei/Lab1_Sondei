namespace Lab1_Sondei.Helpers;

public class MyGC
{
    public void ShowMemory()
    {
        MyGC myGc = new MyGC();
        Console.WriteLine($"The highest generation is {GC.MaxGeneration}");
        FillWithGarbage();
        Console.WriteLine($"Generation: {GC.GetGeneration(myGc)}");
        Console.WriteLine($"Memory used before collection:       ${GC.GetTotalMemory(false)}");
        GC.Collect(0);
        GC.WaitForPendingFinalizers();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("selling cars");
            Thread.Sleep(1000);
        }
        Console.WriteLine($"Total memory:       ${GC.GetTotalMemory(false)}");
        Console.WriteLine($"Generation: {GC.GetGeneration(myGc)}");
        GC.Collect(2);
        Console.WriteLine($"Generation: {GC.GetGeneration(myGc)}");
        Console.WriteLine($"Memory used after full collection:   ${GC.GetTotalMemory(true)}");
        GC.WaitForPendingFinalizers();
    }

    void FillWithGarbage()
    {
        BMW bmw;
        for (int i = 0; i < 10000; i++)
        {
            bmw = new BMW(45678901);   
        }
    }
}