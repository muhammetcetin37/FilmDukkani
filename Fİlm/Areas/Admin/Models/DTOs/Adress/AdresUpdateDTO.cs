using Film.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Models.DTOs.Adress
{
    [Area("Admin")]
    public class AdresUpdateDTO
    {

        public int Id { get; set; }
        public AdresTip? AdresTip { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public string CaddeSokak { get; set; }
        public int DısKapiNo { get; set; }
        public int IcKapiNo { get; set; }
    }
}
