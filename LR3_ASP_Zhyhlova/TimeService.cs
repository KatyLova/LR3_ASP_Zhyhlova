namespace LR3_ASP_Zhyhlova
{
    public class TimeService
    {
        static string GetTime() => DateTime.Now.Hour.ToString();
        int curTime = Int32.Parse(GetTime());
        public string CalculateTime()
        {
            if (curTime >= 12 && curTime <= 18)
            {
                return "<h3><center>It's day now!</center></h3>";
            }
            if (curTime > 18 && curTime <= 24)
            {
                return "<h3><center>It's evening now!</center></h3>";
            }
            if (curTime > 24 && curTime < 6)
            {
                return "<h3><center>It's night now!</center></h3>";
            }
            return "<h3><center>It's morning now</center></h3>";
        }
    }
}