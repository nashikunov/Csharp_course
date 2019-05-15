using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static HW2.Core.transport.Route;

namespace HW2.Core.transport
{
    [Table("Stations")]
    public class Station
    {
        //public Station(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            var station = obj as Station;
            return station != null &&
                   Id == station.Id &&
                   Name == station.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}