using System.Threading.Tasks;

namespace FKRM.Mvc.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}
