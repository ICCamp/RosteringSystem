﻿using RosteringSystem.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public List<Job> JobList() => _context.Jobs.ToList();

        public void CreateJob(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
        }

        public bool UpdateJob(Job job)
        {
            var found = _context.Jobs.Find(job.Id);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(job);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveJobById(int id)
        {
            var found = _context.Jobs.Find(id);
            if (found == null) return false;

            _context.Jobs.Remove(found);
            _context.SaveChanges();
            return true;
        }

        public Job GetJobById(int id)
        {
            return _context.Jobs.Find(id);
        }

        
    }
}
