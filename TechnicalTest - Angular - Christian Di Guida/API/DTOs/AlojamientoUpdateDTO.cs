namespace API.DTOs
{
    public class AlojamientoUpdateDTO
    {
        public int id { get; set; }
        public string codAlojamiento { get; set; }
        public string alojamiento { get; set; }
        public string direccion { get; set; }
        public string observaciones { get; set; }
    }
}