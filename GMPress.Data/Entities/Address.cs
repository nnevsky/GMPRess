using System;

namespace GMPress.Data.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Town { get; set; }
        public string PostIndex { get; set; }
        public string Street { get; set; }
        public string NumHouse { get; set; }
        public string Coordinates { get; set; }

        public string AddressNote { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"г.{Town}, {Street}, {NumHouse}";
        }
    }
}
