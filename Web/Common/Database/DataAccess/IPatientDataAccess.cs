using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Common.Database.Dto;

namespace Common.Database.DataAccess
{
    public interface IPatientDataAccess
    {
        Task AddOrUpdatePatientAsync(Patient patient, CancellationToken cancellationToken);
        Task AddPatientAsync(Patient patient, CancellationToken cancellationToken);

        Task<List<Patient>> FindPatientsAsync(string name, string surname, string personalId,
            CancellationToken cancellationToken);

        Task<List<Patient>> FindPatientsByPersonalIdAsync(string personalId, CancellationToken cancellationToken);
        Task<Patient> GetPatientByGuidAsync(Guid userId, CancellationToken cancellationToken);
    }
}