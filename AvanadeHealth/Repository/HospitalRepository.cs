using AvanadeHealth.Models;
using AvanadeHealth.Repository.Context;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace AvanadeHealth.Repository
{
    public class HospitalRepository
    {
        public readonly DatabaseContext _context;
        public HospitalRepository()
        {
            _context = new DatabaseContext();
        }

        public IList<Hospital> List()
        {
            return _context.Hospital.ToList();
        }

        public void Insert(Hospital hospital)
        {
            _context.Hospital.Add(hospital);
            _context.SaveChanges();
        }

        public void Update(Hospital hospital)
        {
            _context.Hospital.Update(hospital);
            _context.SaveChanges();
        }

        public void Delete(Hospital hospital)
        {
            _context.Hospital.Remove(hospital);
            _context.SaveChanges();
        }
        
    }
}
