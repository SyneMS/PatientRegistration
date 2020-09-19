using iMedOneDB;
using iMedOneDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class Registration : IRegistrationInterface
    {
        public IEnumerable<TBLPATIENT> GetAllPatients()
        {
            return DBContext.GetData<iMedOneDB.Models.TBLPATIENT>();
        }

        public IEnumerable<iMedOneDB.Models.Tblstate> GetAllSates()
        {
            return DBContext.GetData<iMedOneDB.Models.Tblstate>();
        }

        public IEnumerable<Tblcity> GetCities(int stateId)
        {
            return DBContext.GetData<iMedOneDB.Models.Tblcity>(stateId);
        }

        public bool SavePatientDetails(List<TBLPATIENT> patientList)
        {
            return DBContext.SaveAll<iMedOneDB.Models.TBLPATIENT>(patientList);
        }
    }
}
