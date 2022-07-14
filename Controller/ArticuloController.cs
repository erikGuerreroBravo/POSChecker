// Decompiled with JetBrains decompiler
// Type: POSChecker.Controller.ArticuloController
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using POSChecker.Domain;
using POSChecker.Entities;
using System;

namespace POSChecker.Controller
{
  public class ArticuloController
  {
    public static articulo getArticulo(string barCode)
    {
      articulo articulo = articuloDAO.getArticulo(barCode);
      if (articulo == null)
        throw new Exception("No existe el artículo");
      articulo.precio_oferta = articuloDAO.getPriceOffer(barCode);
      return articulo;
    }
  }
}
