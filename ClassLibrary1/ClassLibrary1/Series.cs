using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Series : Shows
    {
        public string NumberOfSeason { get; set; }
        public string NumberOfEpisode { get; set; }
        public Series(string name, string disrc, string host, string numberOfSeason, string numberOfEpisode) : base(name, disrc, host)
        {
            NumberOfSeason = numberOfSeason;
            NumberOfEpisode = numberOfEpisode;
        }

        public override string GetInfo() =>
            $"Номер сезона: {NumberOfSeason} \n Номер эпизода: {NumberOfEpisode}";
    }
}
