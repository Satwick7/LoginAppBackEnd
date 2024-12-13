using Register.Models;

namespace DbLayer
{
    public class UserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User GetUser(User user)
        {
            var userr = _context.Users.Where(u => u.Email == user.Email).FirstOrDefault();

            return userr;
        }

        public bool AddUser(User user) 
        {
            if (user == null) {
                return false;
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }

        public bool AddPatient(Patient patient)
        {
            if (patient == null)
            {
                return false;
            }

            _context.Patients.Add(patient);
            _context.SaveChanges();

            return true;
        }

        public bool AddDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                return false;
            }

            _context.Doctors.Add(doctor);
            _context.SaveChanges();

            return true;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }

        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
