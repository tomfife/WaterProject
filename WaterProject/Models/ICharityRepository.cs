using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface ICharityRepository
    {
        // Setting up a template that we inherit from
        IQueryable<Project> Projects { get; } 
    }
}
