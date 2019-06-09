using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiApplication.Models.Patients;
using WebApiApplication.Services.Patients;


namespace WebApiApplication.Controllers
{
    /// <summary>
    /// Контроллер для работы с пациентами 
    /// </summary>
    public class PatientsController : ApiController
    {
        private readonly IPatientsControllerService _patientsControllerService;

        public PatientsController(IPatientsControllerService patientsControllerService)
        {
            _patientsControllerService = patientsControllerService;
        }

        /// <summary>
        /// Ищет пациентов по заданным в запросе параметрам
        /// Если не найдено ни одного пациента удовлетворяющего условиям возвращается пустой список
        /// </summary>
        [HttpPost]
        [Route("v1/search-patients/")]
        public Task<SearchPatientsResponse> SearchPatientsAsync(SearchPatientsRequest request,
            CancellationToken cancellationToken)
        {
            return _patientsControllerService
                .SearchPatientsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Получает данные пациента по его идентификатору
        /// </summary>
        /// <param name="guid">Идентификатор пользователя</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        /// <returns>Возвращает данные по пациенту, если не найдено такого возвращает null</returns>
        [HttpGet]
        [Route("v1/get-patient")]
        public Task<GetPatientResponse> GetPatientAsync(Guid guid, CancellationToken cancellationToken)
        {
            return _patientsControllerService.GetPatientAsync(guid, cancellationToken);
        }


        [HttpGet]
        [Route("v1/generate-patient/")]
        public async Task AddRandomPatientsAsync(CancellationToken cancellationToken)
        {
            await _patientsControllerService
                .AddRandomPatientAsync(cancellationToken);
        }
    }
}