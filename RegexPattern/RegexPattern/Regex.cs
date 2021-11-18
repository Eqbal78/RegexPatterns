using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPattern
{
    class RegexPttrn
    {
     
        public static void RegexPattern()
        {

            //Regex regex = new Regex(@"\b[M]\w+");
            string pattern = @"\b[M]\w+";
            Regex regex = new Regex(pattern);

            string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";

           
            MatchCollection matchedAuthors = regex.Matches(authors);
             
            for (int i = 0; i < matchedAuthors.Count; i++)
                Console.WriteLine(matchedAuthors[i].Value);

        }
    }
}
