using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FantasySports.Models
{
    public class FantasyFootballViewModel
    {
        private FantasyFootballRepository _repo;

        public FantasyFootballViewModel(FantasySportsContext context)
        {
            
        }

        public int GetPoints()
        {
            return _repo.Points();
        }
    }
}
