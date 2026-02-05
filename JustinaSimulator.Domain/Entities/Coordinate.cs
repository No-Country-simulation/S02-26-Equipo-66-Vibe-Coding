namespace JustinaSimulator.Domain.Entities;

public record Coordinate(double X, double Y, double Z)
{
    public static Coordinate Origin => new(0, 0, 0);

    public override string ToString() => $"({X}, {Y}, {Z})";
}
