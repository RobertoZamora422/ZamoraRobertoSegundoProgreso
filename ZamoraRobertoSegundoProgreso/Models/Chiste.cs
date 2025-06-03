namespace ZamoraRobertoSegundoProgreso.Models
{
    public class Chiste
    {
        public string setup { get; set; }
        public string punchline { get; set; }
        public string TextoCompleto => $"{setup}\n\n{punchline}";
    }
}