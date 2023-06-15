// See https://aka.ms/new-console-template for more information
using Dapper_ORM;

//Console.WriteLine("Hello, World!");

AuthorRepository authorRepository = new AuthorRepository();
//var author = authorRepository.AddAuthor(new Author
//{
//    FirstName = "Ilyas",
//    LastName = "Efendiyev"
//});
//Console.WriteLine(author);


//var authors= authorRepository.GetAuthors().ToList();

//authors.ForEach(c => Console.WriteLine(c));

//authorRepository.AddAuthors(new[]
//{
//    new Author{FirstName = "Ilyas",LastName = "Efendiyev"},
//    new Author{FirstName = "Semed",LastName = "Vekilov"},
//    new Author{FirstName = "Nikolay",LastName = "Qoqol"},
//    new Author{FirstName = "Abbas",LastName = "Mehdizade"},
//    new Author{FirstName = "Celil",LastName = "Memmedquluzade"},
//    new Author{FirstName = "Yusif Vezir",LastName = "Chemenzemenili"},
//    new Author{FirstName = "Xelil Riza",LastName = "Xeliliov"},
//});

//for (int i = 0; i < 100000; i++)
//{
//    authorRepository.AddAuthors(new[]
//{
//    new Author{FirstName = $"{i}Ilyas",LastName = "Efendiyev"},
//    new Author{FirstName = $"{i}Semed",LastName = "Vekilov"},
//    new Author{FirstName = $"{i}Nikolay",LastName = "Qoqol"},
//    new Author{FirstName = $"{i}Abbas",LastName = "Mehdizade"},
//    new Author{FirstName = $"{i}Celil",LastName = "Memmedquluzade"},
//    new Author{FirstName = $"{i}Yusif Vezir",LastName = "Chemenzemenili"},
//    new Author{FirstName = $"{i}Xelil Riza",LastName = "Xeliliov"},
//});
//}

//var authors = authorRepository.GetAuthors().ToList();

//authors.ForEach(c => Console.WriteLine(c));

//authorRepository.RemoveAuthor(15);

//authorRepository.RemoveAuthorByIds(new int[] { 17, 18, 58, 69 });

//authorRepository.RemoveAuthorByRange(1, 16);

//Author updatedAuthor = new Author
//{
//    Id = 21,
//    FirstName = "Orxan",
//    LastName = "Memmedquluzade"
//};

//authorRepository.UpdateAuthor(updatedAuthor);


//Author updatedAuthor = 



//Author[] updatedAuthors = new Author[]
//{
//    new Author { Id = 1, FirstName = "Orxan", LastName = "Memmedquluzade" },
//    new Author { Id = 2, FirstName = "Orxan", LastName = "Memmedquluzade" },
//};

//authorRepository.UpdateAuthors(updatedAuthors);

//Console.WriteLine(authorRepository.GetAuthorById(1)); 