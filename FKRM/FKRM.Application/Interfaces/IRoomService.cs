using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IRoomService
    {
        RoomViewModel GetById(Guid id);
        Task<Response<int>> Register(RoomViewModel roomViewModel);
        IEnumerable<RoomViewModel> GetAll();
        IEnumerable<RoomViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(RoomViewModel roomViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
