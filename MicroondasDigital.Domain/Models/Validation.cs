using MicroondasDigital.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Domain.Models
{
    public class Validation : IValidation
    {
        public IList<string> Errors { get; private set; }

        public Validation()
        {
            Errors = new List<string>();
        }

        public void AddError(string message)
        {
            Clear();
            if(String.IsNullOrEmpty(message))
            {
                Errors.Add(message);
            }
        }

        public bool IsValid()
        {
            return Errors.Count == 0;
        }

        public void Clear()
        {
            Errors.Clear();
        }
    }
}
