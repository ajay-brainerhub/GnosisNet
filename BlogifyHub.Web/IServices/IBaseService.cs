using BlogifyHub.Web.Models;

namespace BlogifyHub.Web.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
