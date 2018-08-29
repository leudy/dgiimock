using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace rncapp.Repository
{
    public class FileRepository
    {
        public static string PathFile { get; set; }
        public static List<Persona> _personas { get; set; }

        public FileRepository()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory() + "/Files/", "DB.txt");
            var Lines = File.ReadAllLines(path).ToList();
            _personas = Lines.Select(
                l => new Persona
                {
                    RNC = l.Split('|')[0],
                    Nombre = l.Split('|')[1],
                    Categoria = l.Split('|')[3],
                    Nombre_Comercial = l.Split('|')[2],
                }).ToList();
        }

        public Persona GetPersona(string rnc)
        {
            return _personas.FirstOrDefault(p => p.RNC == rnc);
        }

        public List<Persona> GetPersonas()
        {
            return _personas;
        }
    }
}