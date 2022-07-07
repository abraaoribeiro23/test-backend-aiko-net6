﻿using Aiko.Domain.Models;
using Aiko.Services.Contracts.EquipmentModel;
using Aiko.Services.Contracts.EquipmentState;
using AutoMapper;

namespace Aiko.Services.Mappers;

public class DtoToDomainMappingProfile : Profile
{
    public DtoToDomainMappingProfile()
    {
        CreateMap<EquipmentModelDto, EquipmentModel>();
        CreateMap<EquipmentModelCreateDto, EquipmentModel>();
        CreateMap<EquipmentModelUpdateDto, EquipmentModel>();

        CreateMap<EquipmentStateDto, EquipmentState>();
        CreateMap<EquipmentStateCreateDto, EquipmentState>();
        CreateMap<EquipmentStateUpdateDto, EquipmentState>();
    }
}