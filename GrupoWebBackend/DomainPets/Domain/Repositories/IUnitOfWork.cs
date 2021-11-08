using System.Threading.Tasks;

namespace GrupoWebBackend.DomainPets.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}