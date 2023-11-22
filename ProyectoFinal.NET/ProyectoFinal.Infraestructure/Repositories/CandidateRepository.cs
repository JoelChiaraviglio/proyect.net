using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Interfaces;
using ProyectoFinal.Infraestructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Infraestructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly SqlServerContext _context;

        public CandidateRepository(SqlServerContext context)
        {
            _context = context;
        }

        public Candidate Get(int id)
        {
            return new Candidate
            {
                Id = id,
                FirstName = "Joel",
                LastName = "Chiaraviglio"

            };
        }

        public List<Candidate> GetList()
        {

            var candidateList = _context.Set<Candidate>().ToList();

            return candidateList;

        }

    }

}


