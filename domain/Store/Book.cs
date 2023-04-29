﻿using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Book(int id,string isbn,string author, string title)
        { 
            Id = id;
            Isbn = isbn;
            Author = author;
            Title = title;
        }

        internal static bool IsIsbn(string s) 
        {
            if(s == null)
                return false;

            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();
            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        }
       }
}