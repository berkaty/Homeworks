using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EducationalPrograms : Shows
    {
        public string SphereOfScience { get; }
        public EducationalPrograms(string name, string disrc, string host, string sphereOfScience) : base(name, disrc, host)
        {
            SphereOfScience = sphereOfScience;
        }

        public override string GetInfo() =>
            $"Сфера науки: {SphereOfScience}";
    }
}
