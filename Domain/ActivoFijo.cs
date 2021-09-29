using Domain.Enums;
using Newtonsoft.Json;
using System;

namespace Domain
{
    [JsonObject (MemberSerialization.OptIn)]
    public class ActivoFijo
    {
        public int Id { get; set; } 
        [JsonProperty]
        public string CodigoActivo { get; set; }
        [JsonProperty]
        public string NombreActivo { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public decimal ValorActivo { get; set; }
        [JsonProperty]
        public DateTime FechaAdquisicion { get; set; }
        [JsonProperty]
        public TipoActivoFijo TipoActivoFijo { get; set; }
        [JsonProperty]
        public MetodoDeDepreciacion MetodoDeDepreciacion { get; set; }
        [JsonProperty]
    }
}
