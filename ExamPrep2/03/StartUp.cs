namespace NewsFeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (NewsFeed)

            NewsFeed newsfeed = new("TechDaily", 3);


            //Initialize entities (Articles)

            Article article1 = new("AI Revolution", "John Sanders", 1500);

            Article article2 = new("Quantum Leap", "Eaugene Smith", 1200);

            Article article3 = new("Exploring Space", "Mark Lee", 1000);

            Article article4 = new("Future Tech", "Emma Davis", 900);


            //Print Article

            Console.WriteLine(article1);

            //Output: Article: 'AI Revolution' by John Sanders - 1500 words


            //Add articles to the NewsFeed

            newsfeed.AddArticle(article1);

            newsfeed.AddArticle(article2);

            newsfeed.AddArticle(article3);


            //Return Articles Count

            Console.WriteLine(newsfeed.GetArticlesCount());

            //Output: 3


            //Attempt to add article4 - should not be added

            newsfeed.AddArticle(article4);

            Console.WriteLine(newsfeed.Report());
        }
    }
}
