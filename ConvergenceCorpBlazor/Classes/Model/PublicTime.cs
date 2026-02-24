using ConvergenceCorpBlazor.Classes.Model.Game; //for GameRegion

namespace ConvergenceCorpBlazor.Classes.Model;

public class PublicTime
{
    private static TimeSpan[] SotOTimes = [
            new TimeSpan(01, 30, 00),
            new TimeSpan(04, 30, 00),
            new TimeSpan(07, 30, 00),
            new TimeSpan(10, 30, 00),
            new TimeSpan(13, 30, 00),
            new TimeSpan(16, 30, 00),
            new TimeSpan(19, 30, 00),
            new TimeSpan(22, 30, 00)
        ];
    private static TimeSpan[] JanthirTimes =
        [
            new TimeSpan(0, 0, 0),
            new TimeSpan(3, 0, 0),
            new TimeSpan(6, 0, 0),
            new TimeSpan(9, 0, 0),
            new TimeSpan(12, 0, 0),
            new TimeSpan(15, 0, 0),
            new TimeSpan(18, 0, 0),
            new TimeSpan(21, 0, 0),
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

        DateTimeOffset now = DateTimeOffset.UtcNow;
        DateTimeOffset nextTime = DateTimeOffset.Now.AddYears(1);
        for(int i = 0; i < publicTimes.Length; ++i)
        {
            DateTimeOffset pub = new DateTimeOffset(now.Year, now.Month, now.Day, publicTimes[i].Hours, publicTimes[i].Minutes, publicTimes[i].Seconds, TimeSpan.Zero);
            if (pub <= nextTime && pub >= now.AddMinutes(-15))
            {
                nextTime = pub;
            }
        }

        return nextTime;
    }
}
