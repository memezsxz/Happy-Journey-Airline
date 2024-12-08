using System;
using System.Windows.Forms;
using HappyJourneyAirline.Lib;
using HappyJourneyAirline.Models;

namespace ProjectSample
{
    class App
    {
        static void Main(string[] args)
        {
            var user = new User();

            foreach (var selfUser in user.GetAllUsers())
            {
                Console.WriteLine($"ID: {selfUser.Id} | Name: {selfUser.FullName} | Username : {selfUser.Username} | Email : {selfUser.Email}");
            }
            Application.Run(new MainAppUI());
            //Console.ReadLine();
        }
    }
}
