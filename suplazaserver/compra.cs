// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.compra
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace POSChecker.suplazaserver
{
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
  [DebuggerStepThrough]
  public class compra
  {
    private bool canceladaField;
    private bool canceladaFieldSpecified;
    private DateTime fecha_cancelacionField;
    private bool fecha_cancelacionFieldSpecified;
    private string fecha_compraField;
    private string id_compraField;
    private string id_pedidoField;
    private string id_proveedorField;
    private short no_entradaField;
    private bool no_entradaFieldSpecified;
    private string no_facturaField;
    private string observacionesField;

    public bool cancelada
    {
      get => this.canceladaField;
      set => this.canceladaField = value;
    }

    [XmlIgnore]
    public bool canceladaSpecified
    {
      get => this.canceladaFieldSpecified;
      set => this.canceladaFieldSpecified = value;
    }

    public DateTime fecha_cancelacion
    {
      get => this.fecha_cancelacionField;
      set => this.fecha_cancelacionField = value;
    }

    [XmlIgnore]
    public bool fecha_cancelacionSpecified
    {
      get => this.fecha_cancelacionFieldSpecified;
      set => this.fecha_cancelacionFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string fecha_compra
    {
      get => this.fecha_compraField;
      set => this.fecha_compraField = value;
    }

    [XmlElement(IsNullable = true)]
    public string id_compra
    {
      get => this.id_compraField;
      set => this.id_compraField = value;
    }

    [XmlElement(IsNullable = true)]
    public string id_pedido
    {
      get => this.id_pedidoField;
      set => this.id_pedidoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string id_proveedor
    {
      get => this.id_proveedorField;
      set => this.id_proveedorField = value;
    }

    public short no_entrada
    {
      get => this.no_entradaField;
      set => this.no_entradaField = value;
    }

    [XmlIgnore]
    public bool no_entradaSpecified
    {
      get => this.no_entradaFieldSpecified;
      set => this.no_entradaFieldSpecified = value;
    }

    [XmlElement(IsNullable = true)]
    public string no_factura
    {
      get => this.no_facturaField;
      set => this.no_facturaField = value;
    }

    [XmlElement(IsNullable = true)]
    public string observaciones
    {
      get => this.observacionesField;
      set => this.observacionesField = value;
    }
  }
}
