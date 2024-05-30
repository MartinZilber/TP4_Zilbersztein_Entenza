static class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; }
    public static List<string> ListaHoteles { get; private set; }
    public static List<string> ListaAereos { get; private set; }
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool seEncontro = false;
        int posicion = ListaDestinos.IndexOf(destinoSeleccionado);
        if (posicion != -1) seEncontro = true;
        return seEncontro;
    }
    
}
