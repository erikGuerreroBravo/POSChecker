// Decompiled with JetBrains decompiler
// Type: POSChecker.Entities.articulo
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;

namespace POSChecker.Entities
{
  public class articulo
  {
    public string cod_barras { set; get; }

    public string cod_asociado { set; get; }

    public string descripcion { set; get; }

    public Decimal precio_venta { set; get; }

    public Decimal precio_oferta { set; get; }

    public string tipo_articulo { set; get; }
  }
}
