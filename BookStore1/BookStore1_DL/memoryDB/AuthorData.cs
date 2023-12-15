using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore1_DL.memoryDB
{
    public class AuthorData
    {
        public static List<Author>AuthorData=
            new list<Author>()
            {
                new Author()
                {
                    ID=1,
                    Name="Author1",
                    BirthDay=DateTime.Now
                }
                new Author()
                {
                    ID=2,
                    Name="Author2",
                    BirthDay=DateTime.Now
                }
                new Author()
                {
                    ID=3,
                    Name="Author3",
                    BirthDay=DateTime.Now
                }
                
            }
    }
}
