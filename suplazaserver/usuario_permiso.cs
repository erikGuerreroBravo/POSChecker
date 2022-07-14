// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.usuario_permiso
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
  public class usuario_permiso
  {
    private DateTime fecha_registroField;
    private bool fecha_registroFieldSpecified;
    private string id_permisoField;
    private string user_nameField;
    private Decimal valor_numField;
    private bool valor_numFieldSpecified;

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

    [XmlElement(IsNullable = true)]
    public string id_permiso
    {
      get => this.id_permisoField;
      set => this.id_permisoField = value;
    }

    [XmlElement(IsNullable = true)]
    public string user_name
    {
      get => this.user_nameField;
      set => this.user_nameField = value;
    }

    public Decimal valor_num
    {
      get => this.valor_numField;
      set => this.valor_numField = value;
    }

    [XmlIgnore]
    public bool valor_numSpecified
    {
      get => this.valor_numFieldSpecified;
      set => this.valor_numFieldSpecified = value;
    }
  }
}
