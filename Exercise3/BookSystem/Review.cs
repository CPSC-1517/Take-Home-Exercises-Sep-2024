using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Review
    {
        private string _ISBN;
        private string _Title;
        private string _Author;
        private string _Reviewer;
        private string _Comment;

        public string ISBN
        {
            get { return _ISBN; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ISBN is required");
                }
                _ISBN = value.Trim();
            }
        }
        public string Title
        {
            get { return _Title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is required");
                }
                _Title = value.Trim();
            }
        }

        public string Author
        {
            get { return _Author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author is required");
                }
                _Author = value.Trim();
            }
        }

        public string Reviewer
        {
            get { return _Reviewer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Reviewer is required");
                }
               _Reviewer = value;
            }
        }

        public RatingType Rating { get; set; }

        public string Comment
        {
            get { return _Comment; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Comment is required");
                }
                _Comment = value.Trim();
            }
        }

        public Review(string isbn, string title, string author, string reviewer, 
                        RatingType rating, string comment)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Reviewer = reviewer;
            Rating = rating;
            Comment = comment;
        }
        public override string ToString()
        {
            return $"{ISBN},{Title},{Author},{Reviewer},{Rating},{Comment}";
        }
       
       
    }
}
