using Film.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Models.DTOs.Adress
{
    [Area("Admin")]
    public class AdresCreateDTO
    {
        public int Id { get; set; }
        public AdresTip? AdresTip { get; set; }
        public string SehirAdi { get; set; }
        public string IlceAdi { get; set; }
        public string CaddeSokak { get; set; }
        public int DısKapiNo { get; set; }
        public int IcKapiNo { get; set; }

    }
}
