// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.pedido
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
  public class pedido
  {
    private DateTime fecha_pedidoField;
    private bool fecha_pedidoFieldSpecified;
    private DateTime fecha_registroField;
    private bool fecha_registroFieldSpecified;
    private string id_pedidoField;
    private string id_proveedorField;
    private long num_pedidoField;
    private bool num_pedidoFieldSpecified;
    private string status_pedidoField;

    public DateTime fecha_pedido
    {
      get => this.fecha_pedidoField;
      set => this.fecha_pedidoField = value;
    }

    [XmlIgnore]
    public bool fecha_pedidoSpecified
    {
      get => this.fecha_pedidoFieldSpecified;
      set => this.fecha_pedidoFieldSpecified = value;
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

    public string id_pedido
    {
      get => this.id_pedidoField;
      set => this.id_pedidoField = value;
    }

    public string id_proveedor
    {
      get => this.id_proveedorField;
      set => this.id_proveedorField = value;
    }

    public long num_pedido
    {
      get => this.num_pedidoField;
      set => this.num_pedidoField = value;
    }

    [XmlIgnore]
    public bool num_pedidoSpecified
    {
      get => this.num_pedidoFieldSpecified;
      set => this.num_pedidoFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string status_pedido
    {
      get => this.status_pedidoField;
      set => this.status_pedidoField = value;
    }
  }
}
