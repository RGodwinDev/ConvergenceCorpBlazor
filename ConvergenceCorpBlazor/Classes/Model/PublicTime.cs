using ConvergenceCorpBlazor.Classes.Model.Game; //for GameRegion

namespace ConvergenceCorpBlazor.Classes.Model;

public static class PublicTime
{
    //day,hour,min,seconds
    private static readonly TimeSpan[] SotOTimes = [
            new TimeSpan(00, 01, 30, 00),
            new TimeSpan(00, 04, 30, 00),
            new TimeSpan(00, 07, 30, 00),
            new TimeSpan(00, 10, 30, 00),
            new TimeSpan(00, 13, 30, 00),
            new TimeSpan(00, 16, 30, 00),
            new TimeSpan(00, 19, 30, 00),
            new TimeSpan(00, 22, 30, 00),
            new TimeSpan(01, 01, 30, 00)
        ];
    private static readonly TimeSpan[] JanthirTimes =
        [
            new TimeSpan(00, 00, 00, 00),
            new TimeSpan(00, 03, 00, 00),
            new TimeSpan(00, 06, 00, 00),
            new TimeSpan(00, 09, 00, 00),
            new TimeSpan(00, 12, 00, 00),
            new TimeSpan(00, 15, 00, 00),
            new TimeSpan(00, 18, 00, 00),
            new TimeSpan(00, 21, 00, 00),
            new TimeSpan(01, 00, 00, 00)
        ];
    private static readonly TimeSpan[] VoETimes =
        [
        //No VoE times for now
        /*
            new TimeSpan(00, 00, 45, 00),
            new TimeSpan(00, 03, 45, 00),
            new TimeSpan(00, 06, 45, 00),
            new TimeSpan(00, 09, 45, 00),
            new TimeSpan(00, 12, 45, 00),
            new TimeSpan(00, 15, 45, 00),
            new TimeSpan(00, 18, 45, 00),
            new TimeSpan(00, 21, 45, 00),
            new TimeSpan(01, 00, 45, 00)
        */
        /*
            new TimeSpan(00, 02, 15, 00),
            new TimeSpan(00, 05, 15, 00),
            new TimeSpan(00, 08, 15, 00),
            new TimeSpan(00, 11, 15, 00),
            new TimeSpan(00, 14, 15, 00),
            new TimeSpan(00, 17, 15, 00),
            new TimeSpan(00, 20, 15, 00),
            new TimeSpan(00, 23, 15, 00),
            new TimeSpan(01, 02, 15, 00)
         */
        ];


    //get the first available time for the specified area.
    public static DateTimeOffset GetNextAreaTime(GameRegion area)
    {
    
        TimeSpan[] publicTimes;
        if (GameRegion.Sky == area)
        {
            publicTimes = PublicTime.SotOTimes;
        }
        else if(GameRegion.Wild == area)
        {
            publicTimes = PublicTime.JanthirTimes;
        }
        else if (GameRegion.Magic == area)
        {
            //REMOVE THIS LINE ON 9/15/2026
            return new DateTimeOffset(2026,09,15,11,00,00,new TimeSpan(0,-5,0,0)); 
            publicTimes = PublicTime.VoETimes;
        }
        else
        {
            throw new ArgumentException("Invalid area specified");
        }

        DateTimeOffset nextTime = DateTimeOffset.UtcNow.AddYears(1);
        for(int i = 0; i < publicTimes.Length; ++i)
        {
            DateTimeOffset pub = 
                new DateTimeOffset(
                    DateTimeOffset.UtcNow.Year, 
                    DateTimeOffset.UtcNow.Month, 
                    DateTimeOffset.UtcNow.Day, 
                    publicTimes[i].Hours, 
                    publicTimes[i].Minutes, 
                    publicTimes[i].Seconds, 
                    TimeSpan.Zero
                    );
            //used for overflow, if the next time is over 24 hours.
            pub = pub.AddDays(publicTimes[i].Days);

            if (pub <= nextTime && pub >= DateTimeOffset.UtcNow.AddMinutes(-15))
            {
                nextTime = pub;
            }
        }
        return nextTime;
    }
}
