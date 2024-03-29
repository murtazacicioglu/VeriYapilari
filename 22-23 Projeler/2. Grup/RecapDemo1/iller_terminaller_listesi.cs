﻿/*
 *  Zeynep Uysal        <zeynepuysal2001@gmail.com>
 *  
 *  Fatma Nur Ayyıldız  <ayyildizfatmanur@gmail.com>
 * 
 * iller_terminaller.cs
 */
using System;

public class Class1
{
    
    public class Terminal
    {
        public string Name { get; set; }
        public Terminal Next { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public Terminal Terminals { get; set; }
        public City Next { get; set; }

        /*Terminale Ekle Metodu */
        public void AddTerminal(string terminalName)
        {
            if (Terminals == null)
            {
                Terminals = new Terminal { Name = terminalName };
            }
            else
            {
                var current = Terminals;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Terminal { Name = terminalName };
            }
        }
    }


    public class BusCompany
    {
        public City Cities { get; set; }


        /* Şehir Ekle Metodu */
        public void AddCity(string cityName)
        {
            if (Cities == null)
            {
                Cities = new City { Name = cityName };
            }
            else
            {
                var current = Cities;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new City { Name = cityName };
            }
        }

        /* Şehir Bulma Metodu */
        public City FindCity(string cityName)
        {
            var current = Cities;
            while (current != null)
            {
                if (current.Name == cityName)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
