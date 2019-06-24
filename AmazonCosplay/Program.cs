using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AmazonCosplay.Interfaces;
using AmazonCosplay.Model;
using AmazonCosplay.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AmazonCosplay
{
    class Program
    {
        private IRepository<Book> _bookRepository;
        public Program(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        static void Main(string[] args)
        {

            //var builder = new ConfigurationBuilder();
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //builder.AddJsonFile("appsettings.json");
            //var config = builder.Build();
            //string connectionString = config.GetConnectionString("DefaultConnection");

            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //var options = optionsBuilder
            //    .UseSqlServer(connectionString)
            //    .Options;


            ApplicationContext uowContext = new ApplicationContext();
            IUnitOfWork uow = new UnitOfWork(uowContext);
            IRepository<Author> authorRepository = new Repository<Author>(uow);
           // authorRepository.GetById(3);
            authorRepository.DeleteById(3);
            uow.Commit();





            //IRepository<Comment> commentsRepository = new Repository<Comment>(uow);
            //var comment = commentsRepository.GetById(2);
            //var parentComment = commentsRepository.GetById(comment.ParentCommentId);

            //Console.WriteLine("\nOriginal comment : {0}", parentComment.Body);
            //Console.WriteLine("\nAnswering comment : {0}", comment.Body);

            //commentsRepository.Delete(commentsRepository.GetById(4));
            //commentsRepository.Delete(commentsRepository.GetById(3));


            using (ApplicationContext context = new ApplicationContext())
            {
                //var book1 = context.Books.Find(1);
                //var comment1 = new Comment
                //{
                //    Name = "User1",
                //    Body ="Great book!",
                //    Book = book1
                //};

                //var commentToComment1 = new Comment
                //{
                //    Name = "User2",
                //    Body = "I agree!",
                //    Book = book1,
                //    ParentComment = comment1
                //};
                //context.Comments.Add(comment1);
                //context.Comments.Add(commentToComment1);
                //context.SaveChanges();


                //var query = context.Comments.Include(c => c.ParentComment).ToList();
                //var query = context.Comments.ToList();
                //var comment = context.Comments.Find(2);
                //var parentComment = context.Comments.Find(comment.ParentCommentId);

                //Console.WriteLine("\nOriginal comment : {0}", parentComment.Body);
                //Console.WriteLine("\nAnswering comment : {0}", comment.Body);
            }
            Console.ReadKey();




        }
    }
}
