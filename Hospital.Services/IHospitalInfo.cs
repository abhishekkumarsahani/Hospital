using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.ViewModels;
using hospitals.Utilities;

namespace Hospital.Services
{
    public interface IHospitalInfo
    {
        PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize);
        HospitalInfoViewModel GetHospitalById(int HospitalId);
        void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void DeleteHospitalInfo(int id);
    }
}
