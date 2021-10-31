﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPublications.Models;

namespace GrupoWebBackend.DomainPublications.Repositories
{
    public interface IPublicationRepository
    {
        Task<IEnumerable<Publication>> ListPublicationsAsync();
        Task AddAsync(Publication publication);
        Task<Publication> FindByIdAsync(int id);
        void Update(Publication publication);
        void Remove(Publication publication);
        Task<IEnumerable<Publication>> FindByUserId(int userId);
    }
}