using System.Threading.Tasks;
using WebAPI.Data.Repo;
using WebAPI.interfaces;
using WebAPI.Interfaces;

namespace WebAPI.Data
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly DataContext dc;

    public UnitOfWork(DataContext dc){
      this.dc = dc;
    }
    public ICityRepository CityRepository =>new CityRepository(dc);

    public IUserRepository UserRepository =>new UserRepository(dc);

      public IFurnishingTypeRepository FurnishingTypeRepository =>
            new FurnishingTypeRepository(dc);

    public IPropertyRepository PropertyRepository => new PropertyRepository(dc);

    public IPropertyTypeRepository propertyTypeRepository => new PropertyTypeRepository(dc);

    public async Task<bool> SaveAsync()
    {
      return await dc.SaveChangesAsync() > 0;
    }
  }
}
