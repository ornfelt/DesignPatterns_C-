using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.Display();
            // Wait for user
            Console.ReadKey();
        }
    }
}
