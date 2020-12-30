﻿using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private SchoolDBContext _ctx;
        public BranchRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Branch branch)
        {
            _ctx.Add(branch);
            _ctx.SaveChanges();
        }

        public IQueryable<Branch> GetBranches()
        {
            return _ctx.Branches;
        }
    }
}
