using Gundam.Core.Models;

namespace Gundam.Core.Interfaces;

public interface IRepository
{
  IEnumerable<MobileSuit> GetMobileSuits();
}