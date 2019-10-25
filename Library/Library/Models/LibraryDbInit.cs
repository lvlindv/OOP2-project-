using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {

        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            //Create test author /*object*/
            Author lindaP = new Author()
            {
                Name = "Linda Petersson"
            };

            //Create test book /*object*/
            Book luluandDumpling = new Book()
            {
                ISBN = "123",
                Title = "The Adventures of Lulu and Dumpling",
                Description = "A book about two friends.",
                Author = lindaP
            };

            BookCopy copy1 = new BookCopy()
            {
                Book = luluandDumpling,
                Condition = 10
            };

            Member viggoLundin = new Member()
            {
                PersonalId = 1996,
                Name = "Viggo Lundin",
                DateOfMembership = new DateTime(2019, 10, 23)
            };

            Loan loan1 = new Loan()
            {
                TimeOfLoan = new DateTime(2019, 10, 24),
                Member = viggoLundin,
                BookCopy = copy1
            };

            //Add test objects to the DbSet.
            context.Authors.Add(lindaP);
            context.Books.Add(luluandDumpling);
            context.BookCopies.Add(copy1);
            context.Members.Add(viggoLundin);
            //context.Loans.Add(loan1);

            //Persist changes to the database
            context.SaveChanges();

        }
    }
}
