using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Article
    {
        private string title_;
        private string content_;
        private string author_;
        internal readonly object TitleProperty;

        public Article()
        {
            title_ = "This is default article title.";
            content_ = "This is some content.";
            author_ = "This is some amazing Author";
        }
        public Article (string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;
        }

        public string Title
        {
            get => this.title_;
            set => title_ = value;
        }

        public string Content
        {
            get => this.content_;
            set => content_ = value;

        }

        public string Author
        {
            get => this.author_;
            set => author_ = value;
        }
        public object ContentProperty { get; internal set; }
        public object AuthorProperty { get; internal set; }

        public void Edit(string content) => Content = content;
        public void Rename(string title) => Title = title;
        public void ChangeAuthor(string author) => Author = author;
        

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author} ";
        }
    }
    class Program
    {
            static void Main(string[] args)
            {
                    int n = int.Parse(Console.ReadLine());
                    List<Article> articles = new List<Article>();

                for (int i = 0; i < n; i++)
                {

                    string[] initilArticle = Console.ReadLine().Split(", ");
                    Article article = new Article(initilArticle[0], initilArticle[1], initilArticle[2]);
                    articles.Add(article);
                }

                string line = Console.ReadLine();
                switch (line)
                {
                    case "title":
                        articles.Sort((article1, article2) =>
                        article1.TitleProperty.CompareTo(article2.TitleProperty));
                        break;
                    case "content":
                        articles.Sort((article1, article2) =>
                       article1.ContentProperty.CompareTo(article2.ContentProperty));
                        break;
                    case "author":
                        articles.Sort((article1, article2) =>
                       article1.AuthorProperty.CompareTo(article2.AuthorProperty));
                        break;
                   
                }

            }
    }
}
