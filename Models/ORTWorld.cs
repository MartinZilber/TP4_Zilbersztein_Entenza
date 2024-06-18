static class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string>{"Buenos Aires","Mar del Plata", "Mendoza", "Córdoba", "Corrientes", "Misiones", "Chubut", "Río Negro", "Santa Cruz", "Cuyo"};
    public static List<string> ListaHoteles { get; private set; }= new List<string>{"Trivago","Italia Hotel", "Recoleta Grand", "Hotel Colón", "Globales República", "Pestana", "ORThotel", "Ker San Telmo", "HTMLhotel", "Mirá la vida hotel"};
    public static List<string> ListaAereos { get; private set; } = new List<string>{"Fórmula 1", "Boeing 737", "ATR83", "Airbus A350-1000", "GAFSACOMM", "Azul Linhas Aereas", "Airbus A380", "Boeing 287", "Embraer 120 Brasilia", "Airbus A220"};
    public static List<string> ListaExcursiones{get;private set;} = new List<string>{"Escalar", "Senderismo", "Surf", "Tirolesa", "Lobos marinos", "Cuatriciclos", "Natación", "Visitas a museos", "Visitas guiadas", "Ferias"};
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool seEncontro = false;
        int posicion = ListaDestinos.IndexOf(destinoSeleccionado);
        if (posicion != -1) seEncontro = true;
        return seEncontro;
    }
}
