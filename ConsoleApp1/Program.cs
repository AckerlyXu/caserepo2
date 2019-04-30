using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




         
        }
        static async void Maina(string[] args)
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
