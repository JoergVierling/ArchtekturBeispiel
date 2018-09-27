namespace SensorLogic.Interfaces
{
    public interface ISensor
    {
        string Name { get; }
        double Calculate();
    }
}
