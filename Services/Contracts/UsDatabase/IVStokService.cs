﻿using Entities.Models.UsDatabase;

namespace Services.Contracts.UsDatabase
{
    public interface IVStokService
    {
        Task AddAsync(VStok entity);

        Task DeleteAsync(VStok entity);

        Task<List<VStok>> GetAllAsync();

        Task<VStok> GetOneAsync(string key);

        Task UpdateAsync(VStok entity);
    }
}
