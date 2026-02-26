using ConvergenceCorpBlazor.Classes.Model.Game; //for GameRegion

namespace ConvergenceCorpBlazor.Classes.Model;

public class PublicTime
{
    //day,hour,min,seconds
    private static TimeSpan[] SotOTimes = [
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
    private static TimeSpan[] JanthirTimes =
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
    private static TimeSpan[] VoETimes =
        [
        //No VoE times for now
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
                    DateTimeOffset.UtcNow.Day + publicTimes[i].Days, 
                    publicTimes[i].Hours, 
                    publicTimes[i].Minutes, 
                    publicTimes[i].Seconds, 
                    TimeSpan.Zero
                    );

            if (pub <= nextTime && pub >= DateTimeOffset.UtcNow.AddMinutes(-15))
            {
                nextTime = pub;
            }
        }

        return nextTime;
    }
}
