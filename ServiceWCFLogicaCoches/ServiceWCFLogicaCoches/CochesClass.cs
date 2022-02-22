using ServiceWCFLogicaCoches.Models;
using ServiceWCFLogicaCoches.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCFLogicaCoches
{
    public class CochesClass : ICochesContract
    {
        private RepositoryCoches repo;

        public CochesClass() { 
        
            this.repo= new RepositoryCoches();
        }

        public Coche FindCoche(int id)
        {

            return this.repo.FindCoche(id);
        }

        public List<Coche> GetCoches()
        {
            return this.repo.GetCoches();
        }
    }
}
