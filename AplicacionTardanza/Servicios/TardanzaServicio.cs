//Aaron Carmona 2023-1360
using System;
using System.Collections.Generic;

public class TardanzaServicio
{
    private List<Tardanza> _tardanzas = new List<Tardanza>();
    public List<Tardanza> ObtenerTardanza() => _tardanzas;
    public void RegistrarTardanza(Tardanza tardanza)
    {
        tardanza.Id = _tardanzas.Count + 1;
        tardanza.FechaHora = DateTime.Now;
        _tardanzas.Add(tardanza);
    }
}