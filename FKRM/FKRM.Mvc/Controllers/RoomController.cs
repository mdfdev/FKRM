using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class RoomController : BaseController<BranchController>
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService, IToastNotification toastNotification) : base(toastNotification)
        {
            _roomService = roomService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _roomService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var roomViewModel = new RoomViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", roomViewModel) });
            }
            else
            {
                var roomViewModel = _roomService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", roomViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, RoomViewModel roomViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _roomService.Register(roomViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{roomViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _roomService.Update(roomViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{roomViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _roomService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", roomViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _roomService.GetById(id).Name;
                var response = _roomService.Remove(id);
                if (response.Result.Data == 400)
                {
                    NotifyErrors(response.Result.Message);
                }
                else
                {
                    NotifyInfo($"{name} حذف شد.");
                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد.");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _roomService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
