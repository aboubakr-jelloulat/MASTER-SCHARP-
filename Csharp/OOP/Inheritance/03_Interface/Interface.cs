using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._03_Interface
{

    /*

        What is an Interface in C#?

        1 *( An interface is a completely "abstract class",
            which can only contain abstract methods and properties (with empty bodies)

        2 * We must provide the implementation of all the methods of interface inside the class that implements it.

        3 * Like abstract classes, interfaces cannot be used to create objects

        4 * Interface methods do not have a body - the body is provided by the "implement" class

        5 * Interface members are by default abstract and public

        6 * An interface cannot contain a constructor (as it cannot be used to create objects)





    */

    public interface IMediaPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    public class Movie : IMediaPlayable
    {
        public string Title { get; set; }

        public Movie(string title)
        {
            Title = title;
        }

        public void Play()
        {
            Console.WriteLine($"Playing movie: {Title}");
        }

        public void Pause()
        {
            Console.WriteLine($"Pausing movie: {Title}");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping movie: {Title}");
        }
    }

    public class Music : IMediaPlayable
    {
        public string Title { get; set; }

        public Music(string title)
        {
            Title = title;
        }

        public void Play()
        {
            Console.WriteLine($"Playing music: {Title}");
        }

        public void Pause()
        {
            Console.WriteLine($"Pausing music: {Title}");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping music: {Title}");
        }
    }





    // ******************  Implementing Multiple Interfaces  *****************

    /* 1 -  * Unlike inheritance, a class can implement multiple interfaces.
        To implement multiple interfaces, separate them with a comma */








    public interface IReadable
    {
        void Read();
    }

    public interface IDownloadable
    {
        void Download();
    }

    public interface IPreviewable
    {
        void Preview();
    }


    public class EBook : IReadable, IDownloadable, IPreviewable
    {
        public string Title { get; set; }

        public EBook(string title)
        {
            Title = title;
        }

        public void Read()
        {
            Console.WriteLine($"Reading eBook: {Title}");
        }

        public void Download()
        {
            Console.WriteLine($"Downloading eBook: {Title} 50%.....");
        }

        public void Preview()
        {
            Console.WriteLine($"Previewing eBook: {Title}");
        }
    }


}
