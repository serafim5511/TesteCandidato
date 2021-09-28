using Domain.Interfaces;
using EntitiesTesteCandidato;
using Infra.Repository.Generics;
using InfraTesteCandidato.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Repositories
{
    public class RepositoryCep : RepositoryGenerics<Cep>, ICep
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryCep()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        
    }
}
