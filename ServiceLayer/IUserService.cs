using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.Models;

namespace ServiceLayer
{
    public interface IUserService
    {
        User GetUser(User user);
        bool AddUser(User user);
        bool AddPatient(Patient patient);
        bool AddDoctor(Doctor doctor);
        List<User> GetAllUsers();
        List<Doctor> GetAllDoctors();
        List<Patient> GetAllPatients();
    }
}
