﻿using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IRoomService
    {
        RoomViewModel GetById(Guid id);
        void Register(RoomViewModel roomViewModel);
        IEnumerable<RoomViewModel> GetAll();
        void Update(RoomViewModel roomViewModel);
        void Remove(Guid id);
    }
}
