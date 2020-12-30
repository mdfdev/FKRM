using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IRoomService
    {
        IEnumerable<RoomViewModel> GetRooms();
        void Create(RoomViewModel roomViewModel);
    }
}
