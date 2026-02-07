using JustinaSimulator.Domain.Enums;
using System.Collections.Generic;

namespace JustinaSimulator.Domain.Entities;

public class Robot
{
    public Guid Id { get; private set; }
    public Coordinate CurrentTarget { get; private set; }
    public List<Coordinate> Trajectory { get; private set; }
    public SafetyStatus CurrentStatus { get; private set; }

    // Hardcoded Safety Zone for MVP (The "Kidney")
    // Let's define it as a cube from (0,0,0) to (10,10,10)
    private readonly Coordinate _minSafe = new(0, 0, 0);
    private readonly Coordinate _maxSafe = new(10, 10, 10);

    public Robot(Guid id)
    {
        Id = id;
        CurrentTarget = Coordinate.Origin;
        Trajectory = new List<Coordinate>();
        Trajectory.Add(CurrentTarget);
        CurrentStatus = SafetyStatus.Safe;
    }

    public void MoveTo(Coordinate newTarget)
    {
        CurrentTarget = newTarget;
        Trajectory.Add(newTarget);

        // Check Safety during Movement
        if (IsInsideZone(newTarget))
        {
            CurrentStatus = SafetyStatus.Safe;
        }
        else
        {
            // Moving outside is a WARNING
            CurrentStatus = SafetyStatus.Warning;
        }
    }

    public void Click()
    {
        // Check Safety during Action (Click)
        if (IsInsideZone(CurrentTarget))
        {
            // Safe operation
            CurrentStatus = SafetyStatus.Safe;
        }
        else
        {
            // Clicking outside is DANGER (Medical Error)
            CurrentStatus = SafetyStatus.Danger;
        }
    }

    private bool IsInsideZone(Coordinate c)
    {
        return c.X >= _minSafe.X && c.X <= _maxSafe.X &&
               c.Y >= _minSafe.Y && c.Y <= _maxSafe.Y &&
               c.Z >= _minSafe.Z && c.Z <= _maxSafe.Z;
    }
}
