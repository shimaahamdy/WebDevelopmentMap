
using lab;

string[] s1 = { "Mohaeb al saed" };
string[] s2 = { "Radwa Ahour", "Moreed" };
string[] s3 = { "Alain de botton" };


var date1 = new DateTime(2008, 3, 1, 7, 0, 0);

List<Book> book = new List<Book>
            {
             new ("12", "the duck who wished to stay black", s1, date1, 200),
             new ("112", "Status Anxiety", s2, date1, 200),
             new ("32", "Tholathiat Garnada", s3, date1, 100),
            };

// User Defined Delegate Datatype
BookFuncDel<Book> fPtr = BookFunctions.GetTitle;                                    
LibraryEngine.ProcessBooks(book, fPtr);

//BCL delegate Datatype
Func<Book, string> BCLP = BookFunctions.GetAuthors;
//LibraryEngine.ProcessBooks(book, BCLP);

//anonymous Method (GetISBN)
LibraryEngine.ProcessBooks(book, delegate (Book book) { return book.ISBN; });

//Lambda Expression(GetPublicationDate)
fPtr = book => book.PublicationDate.ToString();
LibraryEngine.ProcessBooks(book, fPtr);
