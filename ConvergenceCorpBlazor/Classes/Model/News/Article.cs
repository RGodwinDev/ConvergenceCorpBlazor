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
            new Article(1,"April 14th patch preview!", "/images/news/SuperAdventureLogo.png", new DateTimeOffset(2026,4,12,15,00,00,new TimeSpan(-5,0,0)), "SunMatrix",
                "Balance! SAB! MORE!","/News/april-2026-patch-preview",["patch", "news"])
            ];
    }
}
