using System;

namespace JustinaSimulator.Domain.Entities;

public class Robot
{
    public Guid Id { get; private set; }
    public Coordinate CurrentTarget { get; private set; }

    public Robot(Guid id)
    {
        Id = id;
        CurrentTarget = Coordinate.Origin;
    }

    public void MoveTo(Coordinate newTarget)
    {
        // Here we could add validation logic (e.g., maximum range)
        CurrentTarget = newTarget;
    }
}
