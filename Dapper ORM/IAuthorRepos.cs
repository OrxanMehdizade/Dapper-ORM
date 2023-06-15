using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM
{
    internal interface IAuthorRepos
    {
        Author AddAuthor(Author author);
        void AddAuthors(object[] authors);
        void RemoveAuthor(int id);
        void RemoveAuthorByRange(int start, int end);
        void RemoveAuthorByIds(int[] authorIds);

        Author UpdateAuthor(Author author);
        void UpdateAuthors(object[] authors);
        Author GetAuthorById(int id);
        IEnumerable<Author> GetAuthors();


    }
}
