using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void MainThread(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                (obj) =>
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine("I am code in another thread");
                        Thread.Sleep(500);
                    }
                   
                }
            );
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("I am code in main thread");
                Thread.Sleep(500);
            }
            Console.Read();

        }
        static async void Main(string[] args)
        {
          Model model =  await getModel();
        }

        public static async Task<Model> getModel()
        {
            Model model = new Model() { Id = 1, Name = "HELLO" };
            Task<Model> task=   new Task<Model>(() => model);
            model = await task;
            return model;
          
        }

        public class Model
        {
            public int Id  { get; set; }
            public string Name { get; set; }
        }
    }
}
