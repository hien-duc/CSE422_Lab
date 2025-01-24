using System;

namespace Lab3_TranLeHienDuc_CSE422
{
    public class Book : IPrintable
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _year;
        private int _copiesAvailable;

        public string ISBN
        {
            get => _isbn;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ISBN cannot be empty or null");
                _isbn = value;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty or null");
                _title = value;
            }
        }

        public string Author
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author cannot be empty or null");
                _author = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Year cannot be less than 0");
                _year = value;
            }
        }

        public int CopiesAvailable
        {
            get => _copiesAvailable;
            set
            {
                if (value < 0)
                    throw new ArgumentException("CopiesAvailable cannot be less than 0");
                _copiesAvailable = value;
            }
        }

        public bool IsAvailable => CopiesAvailable > 0;

        public Book(string isbn, string title, string author, int year, int copiesAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            CopiesAvailable = copiesAvailable;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Information:");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
            Console.WriteLine($"Status: {(IsAvailable ? "Available" : "Not Available")}");
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }
    }
}