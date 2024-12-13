using DbLayer;
using Register.Models;

namespace ServiceLayer
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public bool AddUser(User user)
        {
            return _repository.AddUser(user);
        }

        public bool AddDoctor(Doctor doctor)
        {
            return _repository.AddDoctor(doctor);
        }

        public bool AddPatient(Patient patient)
        {
            return _repository.AddPatient(patient);
        }

        public User GetUser(User user)
        {
            var userRetrived = _repository.GetUser(user);

            return userRetrived;
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public List<Doctor> GetAllDoctors()
        {
            return _repository.GetAllDoctors();
        }

        public List<Patient> GetAllPatients()
        {
            return _repository.GetAllPatients();
        }
    }
}
