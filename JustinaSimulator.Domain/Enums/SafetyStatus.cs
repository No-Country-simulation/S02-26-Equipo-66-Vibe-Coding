namespace JustinaSimulator.Domain.Enums;

public enum SafetyStatus
{
    Safe,       // Green: Inside the kidney (Operating Zone)
    Warning,    // Yellow: Outside the kidney (Movement only)
    Danger      // Red: Click/Operation attempted outside the kidney
}
