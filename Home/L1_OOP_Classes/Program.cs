﻿using System;
namespace OOP_L1
{

    public class Program
    {
        public static void Main_L1(string[] args)
        {
            Mouses defender = new("Defender");
            defender.color = "Ivory";


            Phone Yorfondegantelfon = new();
            Yorfondegantelfon.color = "White blue .";
            Yorfondegantelfon.GetType();
            Yorfondegantelfon.model = " Yorfone nol bir";
            Yorfondegantelfon.GetType();
            Yorfondegantelfon.SwitchOn();
            Yorfondegantelfon.SwitchOff();
            Console.WriteLine(Yorfondegantelfon.model+"\n"+Yorfondegantelfon.color);


        }

        public class Phone
        {
            public string model;
            public string color;
            public void SwitchOn()
            { Console.WriteLine("Your phone Switched On !"); }

            public void SwitchOff()
            { Console.WriteLine("Your phone Switched Off !"); }


        }
        
    

    }
}