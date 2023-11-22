using FluentValidation;
using ProyectoFinal.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Validators
{
    public class GetCandidateListValidator : AbstractValidator<GetCandidateListRequest>
    {
        public GetCandidateListValidator() 
        {
            
        }
    }
}
