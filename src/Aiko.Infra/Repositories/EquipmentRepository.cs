﻿using Aiko.Domain.Interfaces;
using Aiko.Domain.Models;
using Aiko.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Aiko.Infra.Repositories
{
    public class EquipmentRepository: BaseRepository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(AppDbContext context) : base(context) {}
        
        public override Equipment? GetById(Guid id)
        {
            var query = _dbSet.Where(entity => entity.Id == id)
                .Include(equipment => equipment.EquipmentModel)
                .Include(equipment => equipment.EquipmentStateHistories)
                .Include(equipment => equipment.EquipmentPositionHistories);
            return query.Any() ? query.FirstOrDefault() : null;
        }
    }
}
