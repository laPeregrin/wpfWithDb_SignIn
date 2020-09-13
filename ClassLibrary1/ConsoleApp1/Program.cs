using ClassLibrary1.Services;
using Domain.Models;
using System;
using System.Linq;
using TraderEntityFrameWork;
using TraderEntityFrameWork.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new DbContextOptionsFactory());
            Console.WriteLine(userService.Delete(2));
            Console.ReadLine();
        }
    }
}
