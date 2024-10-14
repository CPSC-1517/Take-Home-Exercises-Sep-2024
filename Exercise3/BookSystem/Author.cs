using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Author
    {
        public List<string> Author_GetList()
        {
            List<string> authorList = new List<string>();

            authorList.Add("Cixin Liu");
            authorList.Add("Steven King");
            authorList.Add("Piece Brown");
            authorList.Add("Adrian Tchaikovsky");
            authorList.Add("Brandon Sanderson");
            authorList.Add("George R. R. Martin");
            authorList.Add("Evan Winter");
            authorList.Add("Karen Miller");

            return authorList.OrderBy(s => s).ToList();
        }

        
      
    }
}
