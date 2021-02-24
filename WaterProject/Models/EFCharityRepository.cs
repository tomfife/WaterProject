using System;
using System.Linq;

namespace WaterProject.Models
{
    public class EFCharityRepository : ICharityRepository
    {
        // Creating a property of type CdbC called context

        private CharityDbContext _context;

        // Constructor - calling class passes in context
            // Stored in private var

        public EFCharityRepository (CharityDbContext context)
        {
            _context = context;
        }

        // It gets set automatically to _context.Projects when we call this

        public IQueryable<Project> Projects => _context.Projects;
    }
}
