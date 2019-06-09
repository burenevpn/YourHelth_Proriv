using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiApplication.Models.Conquests;
using WebApiApplication.Services.Conquest;

namespace WebApiApplication.Controllers
{
    /// <summary>
    /// Контроллер для работы с предписаниями пациентов
    /// </summary>
    public class ConquestController : ApiController
    {
        private readonly IConquestControllerService _conquestControllerService;

        public ConquestController(IConquestControllerService conquestControllerService)
        {
            _conquestControllerService = conquestControllerService;
        }


        /// <summary>
        /// Запрос на квесты пациента
        /// </summary>
        [HttpPost]
        [Route("v1/get-quests/")]
        public Task<QuestsResponse> GetQuestsAsync(QuestsRequest request,
            CancellationToken cancellationToken)
        {
            return _conquestControllerService.GetQuestsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Запрос на конквесты пациента
        /// </summary>
        [HttpPost]
        [Route("v1/get-conquests/")]
        public Task<ConquestsResponse> GetConquestsAsync(ConquestsRequest request,
            CancellationToken cancellationToken)
        {
            return _conquestControllerService.GetConquestsAsync(request, cancellationToken);
        }
    }
}