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

        //list of articles
        public static List<Article> Articles = [
            new Article(4, "State of Ectos June 2026!", "/images/news/stateofectos2026.png", new DateTimeOffset(2026, 6,7,15,00,00, new TimeSpan(-5,0,0)), "SunMatrix",
                "Evaluating the state of Ectos!", "/News/ectosjune2026", ["Guild Wars 2", "Glob of Ectoplasm", "Ecto"]),
            new Article(3, "Anet Announces Guild Wars 3!", "/images/news/gw3announcement.png", new DateTimeOffset(2026, 6,7,15,00,00, new TimeSpan(-5,0,0)), "SunMatrix",
                "The next evolution of the MMO genre!","/News/anet-announces-gw3",["Guild Wars 3","Guild Wars Franchise", "Summer Game Fest 2026", "Summer Game Fest"]),
            new Article(2, "Dragon Bash 2026!", "/images/news/dragonbash2026.png", new DateTimeOffset(2026,6,7,11,00,00, new TimeSpan(-5,0,0)), "SunMatrix", 
                "Bash the Dragon!", "/News/DragonBash2026", ["Dragon Bash", "Guild Wars 2"]),
            new Article(1,"April 14th patch preview!", "/images/news/SuperAdventureLogo.png", new DateTimeOffset(2026,4,12,15,00,00,new TimeSpan(-5,0,0)), "SunMatrix",
                "Balance! SAB! MORE!","/News/april-2026-patch-preview",["Patch", "Guild Wars 2"])
            ];
    }
}
