using Diksi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diksi.Context.Contracts.Models
{
    public interface IContext
    {
        /// <summary>
        /// накладная
        /// </summary>
        ICollection<Nakladnaya> Nakladnayas { get; }
        ICollection<Pokupatel> Pokupatels { get; }
        ICollection<Postavshik> Postavshiks { get; }
        ICollection<Tovar> Tovars { get; }
    }
}
