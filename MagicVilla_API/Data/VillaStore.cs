using MagicVilla_API.Models.Dto;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<villaDto> villaList = new List<villaDto>
        {
            new villaDto { Id = 1, Nombre= "vista a la playa", Ocupantes=3,metrosCuadrados=50},
            new villaDto { Id = 2, Nombre="Vista a la piscina", Ocupantes=3, metrosCuadrados=80}

        };
    }
}
