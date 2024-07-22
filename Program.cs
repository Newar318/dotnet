﻿using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to QFI movies!");

        Console.WriteLine("Please Enter your name for movies list:");

        string name = Console.ReadLine();
        User u = new User();
        u.setUsername(name);
        if (u.getUsername().Equals("asbin", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Welcome to QFI movies! Mr/Mrs {u.getUsername()}");

            Movie m1 = new Movie();
            m1.setTitle("Avengers");

            Console.WriteLine("Now showing:");

            Movie m = new Movie();
            m.setTitle("Avengers: Endgame");
            List<Movie> li = new List<Movie>();
            li.Add(m);
            li.Add(m1);
            li.Add(new Movie("Salaar"));
            li.Add(new Movie("Pathan"));
            li.Add(new Movie("KGF 2"));
            li.Add(new Movie("RRR"));
            li.Add(new Movie("Bhool Bhulaiyaa 2"));
            foreach (var movie in li)
            {
                Console.WriteLine(movie.getTitle());
            }

        }
         
        else
        {
            Console.WriteLine("Unauthorized access!!!");
        }

    }
}