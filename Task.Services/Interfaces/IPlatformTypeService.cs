﻿using Task.Contracts.Modes;
using Task.Services.Interfaces.Generic;

namespace Task.Services.Interfaces
{
    public interface IPlatformTypeService : IService<PlatformType>, INameFilterService<PlatformType>
    {
        
    }
}