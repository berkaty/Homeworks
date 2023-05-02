using System;
namespace ShowsLibrary
{
    public class Show
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Host { get; set; }
        public readonly Frequency Frequency;
        public readonly DateTime Time;
        private string disrc;
        public Show(string name, string disrc, string host, Frequency daily, string v) : this(name, disrc, host)
        {
        }
        public Show(string name, string disrc, string host)
        {
            Name = name;
            this.disrc = disrc;
            Host = host;
        }
        public string GetInfo()
            {
                var Frequency = "";
                return $"{Frequency} {Discription} {Name}. Ведущий {Host}. Время выхода: {Time}";
            }
    }
}
