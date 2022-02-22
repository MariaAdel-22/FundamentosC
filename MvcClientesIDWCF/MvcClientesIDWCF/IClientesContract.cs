﻿using MvcClientesIDWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MvcClientesIDWCF
{
    [ServiceContract]
    public interface IClientesContract
    {
        [OperationContract]
        List<Cliente> GetClientes();

        [OperationContract]
        Cliente FindCliente(int id);   
    }
}
