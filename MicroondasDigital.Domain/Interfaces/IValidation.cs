using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Domain.Interfaces
{
    public interface IValidation
    {
        void AddError(string message);
        bool IsValid();
    }
}
