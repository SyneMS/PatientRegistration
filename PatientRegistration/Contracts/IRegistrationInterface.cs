using System;
using System.Collections.Generic;
using System.Text;
using iMedOneDB.Models;

namespace Contracts
{
    public interface IRegistrationInterface
    {
        IEnumerable<iMedOneDB.Models.Tblstate> GetAllSates();

        IEnumerable<iMedOneDB.Models.Tblcity> GetCities(int stateId);

        IEnumerable<iMedOneDB.Models.TBLPATIENT> GetAllPatients();

        bool SavePatientDetails(List<iMedOneDB.Models.TBLPATIENT> patientList);
    }
}
