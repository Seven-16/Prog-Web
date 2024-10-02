using System;
using System.Collections.Generic;

public class TardanzaServicio
{
    private List<Tardanza> _tardanzas = new List<Tardanza>();
    public List<Tardanza> ObtenerTardanzas() => _tardanzas;
    public void RegistrarTardanza(Tardanza tardanza)
    {
        tardanza.Id = _tardanzas.Count + 1;
        tardanza.FechaHora = DateTime.Now;
        _tardanzas.Add(tardanza);
    }
}