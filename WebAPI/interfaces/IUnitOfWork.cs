using System.Threading.Tasks;
using WebAPI.Interfaces;

namespace WebAPI.interfaces
{
    public interface IUnitOfWork
    {
         ICityRepository CityRepository{get;}

         IUserRepository UserRepository {get;}

         IPropertyRepository PropertyRepository{get;}

IFurnishingTypeRepository FurnishingTypeRepository {get; }
         IPropertyTypeRepository propertyTypeRepository {get;}
         Task<bool> SaveAsync();
    }
}
