using TareasMVC.Entidades;

namespace TareasMVC.Models
{
    public class AlmacenadorArchivoResultado
    {
        public string URL { get; set; }
        public string Titulo { get; set; }

        internal object Select(Func<object, object, ArchivoAdjunto> value)
        {
            throw new NotImplementedException();
        }
    }
}