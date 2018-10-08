namespace BotFactory.Common.Tools
{
    public interface ICoordinates
    {
        double x { get; set; }
        double y { get; set; }

        bool Equals(Coordinates c);
    }
}