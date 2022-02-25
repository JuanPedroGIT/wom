using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Consumer : BaseEntity
    {
         public int IdConsumer { get; set; }
        public string IdExternal { get; set; }
        public bool NewVSLogin { get; set; }
        public string UtmSource { get; set; }
        public string UtmCampaign { get; set; }
         public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string StreetType { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Block { get; set; }
        public string Floor { get; set; }
        public string Door { get; set; }
        public string AddressComplement { get; set; }
        public DateTime RecordDate{ get; set; }


    }
}