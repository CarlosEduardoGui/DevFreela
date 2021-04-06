using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStaterdException : Exception
    {
        public ProjectAlreadyStaterdException() : base("Project is already in Started status")
        {
        }
    }
}
