// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.unidad_medida
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace POSChecker.suplazaserver
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
  [DesignerCategory("code")]
  public class unidad_medida
  {
    private string descripcionField;
    private DateTime fecha_registroField;
    private bool fecha_registroFieldSpecified;
    private string id_unidadField;

    [XmlElement(IsNullable = true)]
    public string descripcion
    {
      get => this.descripcionField;
      set => this.descripcionField = value;
    }

    public DateTime fecha_registro
    {
      get => this.fecha_registroField;
      set => this.fecha_registroField = value;
    }

    [XmlIgnore]
    public bool fecha_registroSpecified
    {
      get => this.fecha_registroFieldSpecified;
      set => this.fecha_registroFieldSpecified = value;
    }

    public string id_unidad
    {
      get => this.id_unidadField;
      set => this.id_unidadField = value;
    }
  }
}
