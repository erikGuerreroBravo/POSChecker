// Decompiled with JetBrains decompiler
// Type: POSChecker.suplazaserver.usuario
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
  public class usuario
  {
    private bool enableField;
    private bool enableFieldSpecified;
    private DateTime fecha_registroField;
    private bool fecha_registroFieldSpecified;
    private string passwordField;
    private string tipo_usuarioField;
    private string user_nameField;

    public bool enable
    {
      get => this.enableField;
      set => this.enableField = value;
    }

    [XmlIgnore]
    public bool enableSpecified
    {
      get => this.enableFieldSpecified;
      set => this.enableFieldSpecified = value;
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

    [XmlElement(IsNullable = true)]
    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    [XmlElement(IsNullable = true)]
    public string tipo_usuario
    {
      get => this.tipo_usuarioField;
      set => this.tipo_usuarioField = value;
    }

    [XmlElement(IsNullable = true)]
    public string user_name
    {
      get => this.user_nameField;
      set => this.user_nameField = value;
    }
  }
}
