using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    // NAO ADEQUADO PARA USO
    public class ServiceLocator2Controller : Controller
    {

        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // Retorna null se não estiver registrado
            serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}