// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.oferta
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace POSChecker.suplazaserver
{
  [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class oferta
  {
    private string cod_barrasField;
    private DateTime fecha_finField;
    private bool fecha_finFieldSpecified;
    private DateTime fecha_iniField;
    private bool fecha_iniFieldSpecified;
    private string id_ofertaField;
    private DateTime last_syncField;
    private bool last_syncFieldSpecified;
    private Decimal precio_ofertaField;
    private bool precio_ofertaFieldSpecified;
    private string status_ofertaField;

    [XmlElement(IsNullable = true)]
    public string cod_barras
    {
      get => this.cod_barrasField;
      set => this.cod_barrasField = value;
    }

    public DateTime fecha_fin
    {
      get => this.fecha_finField;
      set => this.fecha_finField = value;
    }

    [XmlIgnore]
    public bool fecha_finSpecified
    {
      get => this.fecha_finFieldSpecified;
      set => this.fecha_finFieldSpecified = value;
    }

    public DateTime fecha_ini
    {
      get => this.fecha_iniField;
      set => this.fecha_iniField = value;
    }

    [XmlIgnore]
    public bool fecha_iniSpecified
    {
      get => this.fecha_iniFieldSpecified;
      set => this.fecha_iniFieldSpecified = value;
    }

    public string id_oferta
    {
      get => this.id_ofertaField;
      set => this.id_ofertaField = value;
    }

    public DateTime last_sync
    {
      get => this.last_syncField;
      set => this.last_syncField = value;
    }

    [XmlIgnore]
    public bool last_syncSpecified
    {
      get => this.last_syncFieldSpecified;
      set => this.last_syncFieldSpecified = value;
    }

    public Decimal precio_oferta
    {
      get => this.precio_ofertaField;
      set => this.precio_ofertaField = value;
    }

    [XmlIgnore]
    public bool precio_ofertaSpecified
    {
      get => this.precio_ofertaFieldSpecified;
      set => this.precio_ofertaFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string status_oferta
    {
      get => this.status_ofertaField;
      set => this.status_ofertaField = value;
    }
  }
}
