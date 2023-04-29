using Domain_CampFinalProject.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Application_CampFinalProject.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        DbSet<T> Table { get; }
    }
}
