using HospitalManagement.DTOs;

namespace HospitalManagement.Interfaces
{
    public interface IAuthService
    {
        string Login(LoginRequest request);
    }
}
