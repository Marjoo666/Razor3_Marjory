namespace RutasPracticaRodri
{
    public class Persona
    {
        public string name { get; set; }
        public int edad { get; set; }
        public string empresa { get; set; }

        public Persona(string nombre, int edad, string empresa)
        {
            this.name = nombre;
            this.edad = edad;
            this.empresa = empresa;
        }
    }
}