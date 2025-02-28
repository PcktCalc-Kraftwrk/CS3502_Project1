/*Griffin Vines
001073475
OS 3502 Project 1*/
using System;
using System.Threading;
class Program
{
	private static Random code = new Random();//random number generator
	private static Mutex mut = new Mutex();
	private const int iterations = 1;
	private static int loading = code.Next(1,10);
	static void Main(string[] args)
	{
		for(int s = 0; s < loading; s++) //creates set amount of threads
		{
			Thread thread = new Thread(new ThreadStart(dock));
			thread.Name = String.Format("Ship # {0}", code.Next(001,999));
			thread.Start();
		}
	}
	private static void dock()//calls process
	{
		for(int I = 0; I < iterations; I++)
		{
			dockWork();
		}
	}
	private static void dockWork()
	{
		Console.WriteLine("{0} is entering port", Thread.CurrentThread.Name);
		if(mut.WaitOne(code.Next(200,1000)))//prevents deadlock by impsoing a time limit
		{
		Console.WriteLine("{0} has docked", Thread.CurrentThread.Name);
		Thread.Sleep(70);
		Console.WriteLine("{0} has dropped:", Thread.CurrentThread.Name);
		Console.WriteLine("--{0} units of inventory", code.Next(1, 100));
		Console.WriteLine("--{0} employees", code.Next(1, 15));
		Thread.Sleep(30);
		Console.WriteLine("{0} has taken:", Thread.CurrentThread.Name);
		Console.WriteLine("--{0} units of inventory", code.Next(10, 150));
		Console.WriteLine("--{0} employees", code.Next(5, 30));
		mut.ReleaseMutex(); //prevents deadlock by removing thread from process
		Console.WriteLine("{0} has left the port", Thread.CurrentThread.Name);
		}
		else //if the threads have been waiting for too long
		{
		Console.WriteLine("{0} is unable to enter the shipyard", Thread.CurrentThread.Name);
		}
	}
}
