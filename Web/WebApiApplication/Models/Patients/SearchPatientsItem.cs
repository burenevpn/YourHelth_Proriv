using System;
using System.Runtime.Serialization;

namespace WebApiApplication.Models.Patients
{
    /// <summary>
    /// Модель данных для результата поиска пациентов
    /// </summary>
    [DataContract]
    public class SearchPatientsItem
    {
        /// <summary>
        /// Идентификатор пациента
        /// </summary>
        [DataMember(Name = "guid")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пациента
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Снилс 
        /// </summary>
        [DataMember(Name = "personalId")]
        public string PersonalId { get; set; }
    }
}