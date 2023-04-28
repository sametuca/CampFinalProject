using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.CampFinalProjectAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); //Mediator varsa onu donder yoksa IOC den Mediator 'ı cek.
    }
}
