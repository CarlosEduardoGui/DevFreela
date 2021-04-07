using System;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStaterdException : Exception
    {
        public ProjectAlreadyStaterdException() : base("Project is already in Started status")
        {
        }
    }
}
