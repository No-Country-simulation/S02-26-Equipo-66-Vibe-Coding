using JustinaSimulator.Domain.Entities;
using System.Threading.Tasks;

namespace JustinaSimulator.Application.Interfaces;

public interface ISimulationStateRepository
{
    Task<Robot> GetRobotAsync();
    Task UpdateRobotAsync(Robot robot);
}
