// Decompiled with JetBrains decompiler
// Type: POSChecker.Domain.articuloDAO
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using POSChecker.Entities;
using System;
using System.Data.Common;
using System.Data.SQLite;

namespace POSChecker.Domain
{
  public class articuloDAO : pos_checker
  {
    public static articulo getArticulo(string barCode)
    {
      articulo articulo = (articulo) null;
      SQLiteDataReader data = pos_checker.GetData(string.Format("SELECT cod_barras,cod_asociado,descripcion,precio_venta FROM articulo WHERE cod_barras = '{0}'", (object) barCode));
      if (((DbDataReader) data).Read())
      {
        articulo = new articulo();
        articulo.cod_barras = ((DbDataReader) data)["cod_barras"].ToString();
        articulo.cod_asociado = ((DbDataReader) data)["cod_asociado"].ToString();
        articulo.descripcion = ((DbDataReader) data)["descripcion"].ToString();
        articulo.precio_venta = Decimal.Parse(((DbDataReader) data)["precio_venta"].ToString());
      }
      return articulo;
    }

    public static bool existItem(string barCode) => pos_checker.GetData(string.Format("SELECT cod_barras FROM articulo WHERE cod_barras='{0}'", (object) barCode)).StepCount > 0;

    public static bool existOffer(string id_oferta, string barCode) => pos_checker.GetData(string.Format("SELECT id_oferta,cod_barras FROM oferta WHERE id_oferta='{0}' AND cod_barras='{1}'", (object) id_oferta.ToUpper(), (object) barCode)).StepCount > 0;

    public static Decimal getPriceOffer(string barCode)
    {
      SQLiteDataReader data = pos_checker.GetData(string.Format("SELECT precio_oferta  FROM oferta WHERE (status_oferta='disponible' AND '{0}' BETWEEN fecha_ini AND fecha_fin) AND cod_barras IN (SELECT cod_barras FROM articulo WHERE cod_asociado IN (SELECT cod_asociado FROM articulo WHERE cod_barras='{1}'))ORDER BY fecha_fin DESC LIMIT 1", (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), (object) barCode));
      return ((DbDataReader) data).Read() ? Decimal.Parse(((DbDataReader) data)["precio_oferta"].ToString()) : 0M;
    }
  }
}
