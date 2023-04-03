using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithExistingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context=new PlutoContext();

            // Linq Syntax
            var query = from c in context.Courses
                        where c.Name.Contains("C#")
                        orderby c.Name
                        select c;
                      

            foreach(var c in query)
            {
                Console.WriteLine(c.Name+"  "+c.Description);
            }

            //Console.WriteLine(query.ToString());

            //Extensions Method
            //using lambda expression
            var course = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach (var c in course)
            {
                Console.WriteLine(c.Name + "  " + c.Description);
            }

            //Inner Join 
            var res = context.Courses.Join(context.Authors,
                c => c.Author_Id,
                a => a.Id,
                (cours, author) =>
                new
                {
                     CourseName=cours.Name,
                     AuthorName=author.Name
                });

            foreach(var c in res)
            {
                Console.WriteLine(c.CourseName+"  "+c.AuthorName
                    );
            }


            //Group Join 
            var r = context.Authors.GroupJoin(context.Courses, a => a.Id, c => c.Author_Id, (cour, author) => new
            {
                Author = author.Count(),
                Courses = cour.Name
            });

            foreach(var c in r)
            {
                Console.WriteLine(c.Courses+"  "+c.Author);
            }

            //Cross Join

            var n= context.Authors.SelectMany(a => context.Courses, (author, cours) => new
            {
                AuthorName = author.Name,
                CourseName = cours.Name
            });

            foreach(var c in n)
            {
                Console.WriteLine(c.CourseName);
            }


            // Lazy Loading..............

            var lazy = context.Courses.Single(c => c.Id == 2);

            foreach(var tag in lazy.Tags) //here we send another query to data base is called Lazy Loading...
            {
                Console.WriteLine("lazy Loading : "+tag.Name);
            }




            Console.ReadLine(); 
        }
    }
}
