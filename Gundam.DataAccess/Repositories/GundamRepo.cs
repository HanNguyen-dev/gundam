using Gundam.DataAccess.Entities;
using Gundam.Core.Interfaces;

namespace Gundam.DataAccess.Repositories;

public class GundamRepo : IRepository
{
  private static readonly GundamContext _db = new GundamContext();

  public IEnumerable<Core.Models.MobileSuit> GetMobileSuits()
  {
    return _db.MobileSuits.Select(ms => new Core.Models.MobileSuit {
      GundamId = ms.GundamId,
      Model = ms.Model,
      Pilot = ms.Pilot
    });
  }
}
