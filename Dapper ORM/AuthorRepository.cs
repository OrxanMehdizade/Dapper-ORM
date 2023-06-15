using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM
{
    internal class AuthorRepository:IAuthorRepos
    {
        private IDbConnection _connection;
        public AuthorRepository()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        }

        public Author AddAuthor(Author author)
        {
            var sql = @"INSERT INTO Authors(FirstName,LastName)
                       VALUES(@FirstName,@LastName)
                       SELECT CAST(SCOPE_IDENTITY() AS int) ";
            var id=_connection.Query<int>(sql, new
            {
                @FirstName=author.FirstName,
                @LastName=author.LastName,
            } ).FirstOrDefault();
            author.Id = id;
            return author;

        }

        public void AddAuthors(object[] authors)
        {
            var sql = @"INSERT INTO Authors(FirstName,LastName)
              VALUES (@FirstName,@LastName)";
            _connection.Execute(sql, authors);
        }

        public Author GetAuthorById(int id)
        {
            var sql = "SELECT * FROM Authors WHERE Id = @Id";
            return _connection.Query<Author>(sql, new { @Id = id }).FirstOrDefault()!;
        }

        public IEnumerable<Author> GetAuthors()
        {
            var sql = "SELECT * FROM Authors";
            return _connection.Query<Author>(sql);
        }

        public void RemoveAuthor(int id)
        {
            _connection.Execute("DELETE FROM Authors Where Id=@Id", new { @Id = id });
        }

        public void RemoveAuthorByIds(int[] authorIds)
        {
            for (int i = 0; i < authorIds.Length; i++)
            {
                RemoveAuthor(authorIds[i]);
            }
        }

        public void RemoveAuthorByRange(int start, int end)
        {
            for(int i = start; i < end; i++)
            {
                RemoveAuthor(i);
            }
        }

        public Author UpdateAuthor(Author author)
        {
            var sql = @"UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";

            _connection.Execute(sql, new
            {
                @FirstName = author.FirstName,
                @LastName = author.LastName,
                @Id = author.Id
            });

            return author;
        }

        public void UpdateAuthors(object[] authors)
        {
           foreach (var author in authors)
            {
                UpdateAuthor((Author)author);
            }
        }
    }
}
