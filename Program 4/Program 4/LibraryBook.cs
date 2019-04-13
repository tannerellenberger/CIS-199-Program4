using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    using static System.Console;

    public class LibraryBook
    {
        private string _title; //title of book
        private string _author; //author of book
        private string _publisher; //publisher of book
        private int _copyrightYear; //copyright year of book
        private string _callNumber; //call number of book
        private bool checkedOut; // determines whether book is checked out or not

        // read only property, gets title of book
        public string Title
        {
            get { return _title; } //Precondition: none
            set { _title = value; } //Postcondition: sets the value of title
        }
        
        // read only property, gets the author of the book
        public string Author
        {
            get { return _author;  } //Precondition: none
            set { _author = value;  } //Postcondition: sets the value for author
        }
       
        // read only property, gets publisher of book
        public string Publisher
        {
            get { return _publisher;  } //Precondition: none
            set { _publisher = value; } //Postcondition: sets the value for the publisher
        }
        
        // read only property, gets copyright year, or assigns 2017 if non-negative value
        public int CopyrightYear
        {

            get
            {
                return _copyrightYear; //Precondition: must be non negative
            }
            set
            {
                if (value >= 0) //if statement to make sure it is non negative
                    _copyrightYear = value; //Postcondition: if non negative integer, sets value for copyright year
                else
                    _copyrightYear = 2017; //assign 2017 if negative input 
            }
        }

        // read only property, gets the call number 
        public string CallNumber
        {
            get { return _callNumber; } //Precondition: none
            set { _callNumber = value; } //Postcondition: sets value for call number
        }



        // five-parameter constructor
        //Precondition: input of 5 values
        //Postcondition: assigns values to new variables

        public LibraryBook(string title, string author, string publisher, int copyrightYear,
                           string callNumber)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
        }
        // end of constructor

         
        //Precondition: none
        //Postcondition: returns value true to checkedOut
        public void CheckOut()
        {
            checkedOut = true;
            
        }
        //Precondition:none
        //Postcondition: returns value false

        public void ReturnToShelf()
        {

            checkedOut = false;
            
        }
        //Precondition: none
        //Postcondition: returns the checkedOut value, depending on the above methods
        public bool IsCheckedOut()
        {
            
           return checkedOut;
            
        }

        //Precondition: must have inputs
        //Postcondition: writes string of input values

        //return string of LibraryBook object
        public override string ToString()
        {
            string product;

         product = $"Title:            {Title}  {Environment.NewLine}" +
                   $"Author:           {Author} {Environment.NewLine}" +
                   $"Publisher:        {Publisher}  {Environment.NewLine}" +
                   $"Copyright Year:   {CopyrightYear}  {Environment.NewLine}" +
                   $"Call Number:      {CallNumber}  {Environment.NewLine}" +
                   $"Check out status: {checkedOut} {Environment.NewLine}";

            return product;
        } //end of ToString
    }//end of class

}//end of program
