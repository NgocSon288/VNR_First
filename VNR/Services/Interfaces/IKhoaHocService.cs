using System.Collections.Generic;
using System.Threading.Tasks;
using VNR.Dto.KhoaHoc;
using VNR.Entities;

namespace VNR.Services.Interfaces
{
    public interface IKhoaHocService
    {
        Task<List<KhoaHocDto>> GetAll();
        Task<KhoaHocDto> GetById(int id);
    }
}