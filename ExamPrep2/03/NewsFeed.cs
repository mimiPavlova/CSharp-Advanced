using System.Text;

namespace NewsFeed
{
    public class NewsFeed
    {
        public NewsFeed(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            articles=new List<Article> ();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<Article> articles;
        public List<Article> Articles => articles;

        public void AddArticle(Article article)
        {
            if (articles.Count<Capacity)
            {
                if(!articles.Any(a=>a.Title == article.Title))
                {
                    articles.Add(article);

                }
                
            }
        }
        public  bool DeleteArticle(string title)
        {
            Article article=articles.FirstOrDefault(a=>a.Title == title);
            if (article != null)
            {
                articles.Remove(article);
                return true;
            }
            return false;
        }

        public Article GetShortestArticle()
        {
            return articles.OrderBy(a => a.WordCount).FirstOrDefault();
         
        }

        public string GetArticleDetails(string title)
        {
            Article a =articles.FirstOrDefault(a=>a.Title==title);
            if(a is null)
            {
                return $"Article with title '{title}' not found.";
            }
            return a.ToString();
        }
        public int GetArticlesCount()=>articles.Count;

        public string Report()
        {
           
            var sorted = articles.OrderBy(a => a.WordCount).ToList();
            
            StringBuilder sb=   new StringBuilder();
            sb.AppendLine($"{Name} newsfeed content:");
            foreach (var a in sorted)
            {
                sb.AppendLine($"{a.Author}: {a.Title}");
            }
            return sb.ToString().Trim();
        }
    }
}
