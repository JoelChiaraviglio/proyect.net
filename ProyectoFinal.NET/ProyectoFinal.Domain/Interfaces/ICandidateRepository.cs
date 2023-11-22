using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Interfaces
{
    public interface ICandidateRepository
    {
        List<Candidate> GetList();

        Candidate Get(int id);
    }
}
