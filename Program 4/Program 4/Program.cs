//A7793
//December 5th, 2017
//CIS 199-01
//Program 4
//Program lets user see what books are checked out or not


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    using static System.Console;

    class Program
    {


        static void Main(string[] args)
        {


            // derived class objects

            LibraryBook book1 =
                new LibraryBook("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", 1964, "BC");
            LibraryBook book2 =
                new LibraryBook("Where the Red Fern Grows", "Wilson Rawls", "Doubleday", 1961, "LC");
            LibraryBook book3 =
                new LibraryBook("The Alchemist", "Paulo Coelho", "HarperTorch", 1990, "PC");
            LibraryBook book4 =
                new LibraryBook("Candide", "Voltaire", "Cramer", 1820, "OC");
            LibraryBook book5 =
                new LibraryBook("The Stranger", "Albert Camus", "Camus", 1984, "HC");


            //create array for 5 objects
            LibraryBook[] books = new LibraryBook[5];


            //initialize array with objects
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            // ----------------------------------------------------------------------------------
            //Dr. Wright I had trouble constructing a method for these tests. 
            //Instead I tried doing it without a method, because I had an overload error.
            //My apologies for leaving the method out, I couldn't get it to run otherwise.
            // ----------------------------------------------------------------------------------

            WriteLine("Before: ");
            WriteLine();
        
        
            // for each loop to assign arrays to the ToString
            foreach (LibraryBook currentBook in books)
            {
                Console.WriteLine(currentBook); //implicitly calls ToString method
            } //end foreach 

            WriteLine("After: ");
            WriteLine();

            // data manipulation for 2nd test

            book1.Publisher = "Grant"; 
            book1.CheckOut(); //show that book is checked out
            book2.Publisher = "John";
            book3.Publisher = "Max";
            book4.Publisher = "Bad";
            book5.Publisher = "Tim";
            book5.CheckOut(); //show that book is checked out


            // for each loop to assign arrays to the ToString
            foreach (LibraryBook currentBook in books)
            {
                Console.WriteLine(currentBook); //implicitly calls ToString method
            } //end foreach 


            WriteLine("Books that are currently checked out: ");
            WriteLine();
            WriteLine();
            WriteLine();

            WriteLine(book1); //displays the books that are checked out
            WriteLine(book5); // same as above
            

        } //end main  
        
    } //end progran
}
