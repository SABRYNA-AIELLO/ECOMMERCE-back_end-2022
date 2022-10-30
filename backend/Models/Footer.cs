namespace backend.Models
{
    public class Footer
    {
        public string direccion { get; set; }
        public string horario { get; set; }
        public string telefono { get; set; }

        internal object GetFooterData()
        {
            throw new NotImplementedException();
        }
    }
}
