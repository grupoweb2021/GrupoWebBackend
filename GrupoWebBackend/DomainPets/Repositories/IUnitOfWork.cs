using System.Threading.Tasks;

namespace GrupoWebBackend.DomainPets.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}