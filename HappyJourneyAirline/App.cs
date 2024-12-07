using System;
using System.Windows.Forms;
using HappyJourneyAirline.Lib;

namespace ProjectSample
{
    class App
    {
        static void Main(string[] args)
        {
            //Database dbCon = new Database();
            //dbCon.ConnectAndQuery();
            Application.Run(new MainAppUI());
            Console.ReadLine();
        }
    }
}
