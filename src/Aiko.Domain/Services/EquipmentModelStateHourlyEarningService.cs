﻿using Aiko.Domain.Interfaces;
using Aiko.Domain.Models;

namespace Aiko.Domain.Services
{
    public class EquipmentModelStateHourlyEarningService : BaseService<EquipmentModelStateHourlyEarning>
    {
        public EquipmentModelStateHourlyEarningService(IEquipmentModelStateHourlyEarningRepository repository,
            IUnitOfWork unitOfWork): base(repository, unitOfWork)
        {
        }
    }
}
