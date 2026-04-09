namespace ConvergenceCorpBlazor.Classes.Model.News
{
    public record Article(
        int ID,
        string Title, 
        string ImageLink, 
        DateTimeOffset PublishDate,
        string Author,
        string Snippet,
        string Link,
        List<string> Tags
        )
    {
        //add any functions for articles here.
        public static List<Article> Articles = [
            new Article(1,"Most Edible Bunnies!", "/images/news/ediblebunny.jpeg",DateTimeOffset.UtcNow,"CatMatrix", 
                "Bunnies taste of...","/News/bunnys" , ["bunnys", "animals", "recipes"]),
            new Article(2,"Cats are EVIL!", "/images/news/evilcat.jpg", DateTimeOffset.UtcNow, "BunMatrix", 
                "Cats see us as...", "/News/cats", ["cats", "animals", "conspiracy"])
        ];

    }
}
