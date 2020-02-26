
// NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/WebBasketAPI.Models")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/WebBasketAPI.Models", IsNullable = false)]
public partial class ArrayOfJugadores
{

    private ArrayOfJugadoresJugadores[] jugadoresField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Jugadores")]
    public ArrayOfJugadoresJugadores[] Jugadores
    {
        get
        {
            return this.jugadoresField;
        }
        set
        {
            this.jugadoresField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/WebBasketAPI.Models")]
public partial class ArrayOfJugadoresJugadores
{

    private sbyte dorsalField;

    private byte idField;

    private string nombreJugadorField;

    private string paisField;

    private decimal valoracionField;

    /// <remarks/>
    public sbyte Dorsal
    {
        get
        {
            return this.dorsalField;
        }
        set
        {
            this.dorsalField = value;
        }
    }

    /// <remarks/>
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string NombreJugador
    {
        get
        {
            return this.nombreJugadorField;
        }
        set
        {
            this.nombreJugadorField = value;
        }
    }

    /// <remarks/>
    public string Pais
    {
        get
        {
            return this.paisField;
        }
        set
        {
            this.paisField = value;
        }
    }

    /// <remarks/>
    public decimal Valoracion
    {
        get
        {
            return this.valoracionField;
        }
        set
        {
            this.valoracionField = value;
        }
    }
}