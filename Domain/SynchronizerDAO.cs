// Decompiled with JetBrains decompiler
// Type: POSChecker.Domain.SynchronizerDAO
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using POSChecker.Controller;
using POSChecker.suplazaserver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace POSChecker.Domain
{
  public class SynchronizerDAO : pos_checker
  {
    private string dateInitial = "01/05/2017 07:00:00";

    public void syncArticulos()
    {
      List<articulo> list = Enumerable.ToList<articulo>((IEnumerable<articulo>) new SyncCatalogos().getItemsForKiosk(this.getLastChangeDateTimeItems()));
      if (list.Count > 0)
      {
        foreach (articulo articulo in list)
        {
          SQLiteCommand sqLiteCommand = new SQLiteCommand(articuloDAO.existItem(articulo.cod_barras) ? "UPDATE articulo SET cod_asociado=@cod_asociado,descripcion=@descripcion,precio_venta=@precio_venta,last_sync=@last_sync WHERE cod_barras=@cod_barras" : "INSERT INTO articulo(cod_barras,cod_asociado,descripcion,precio_venta,last_sync) VALUES(@cod_barras,@cod_asociado,@descripcion,@precio_venta,@last_sync)", pos_checker.getConnection());
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@cod_barras", (object) articulo.cod_barras));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@cod_asociado", (object) articulo.cod_asociado));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@descripcion", (object) articulo.descripcion));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@precio_venta", (object) articulo.precio_venta));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@last_sync", (object) articulo.fecha_registro));
          ((DbCommand) sqLiteCommand).ExecuteNonQuery();
          ((Component) sqLiteCommand).Dispose();
          GC.Collect();
        }
      }
      list.Clear();
      GC.Collect();
    }

    public void syncOfertas()
    {
      List<oferta> list = Enumerable.ToList<oferta>((IEnumerable<oferta>) new SyncCatalogos().getOffersforKiosk(this.getLastChangeDateTimeOffers()));
      if (list.Count > 0)
      {
        foreach (oferta oferta in list)
        {
          SQLiteCommand sqLiteCommand = new SQLiteCommand(articuloDAO.existOffer(oferta.id_oferta, oferta.cod_barras) ? "UPDATE oferta SET precio_oferta=@precio_oferta,status_oferta=@status_oferta,fecha_ini=@fecha_ini,fecha_fin=@fecha_fin,last_sync=@last_sync WHERE (id_oferta=@id_oferta AND cod_barras=@cod_barras)" : "INSERT INTO oferta(id_oferta,cod_barras,precio_oferta,status_oferta,fecha_ini,fecha_fin,last_sync) VALUES(@id_oferta,@cod_barras,@precio_oferta,@status_oferta,@fecha_ini,@fecha_fin,@last_sync)", pos_checker.getConnection());
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@id_oferta", (object) oferta.id_oferta.ToUpper()));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@cod_barras", (object) oferta.cod_barras));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@precio_oferta", (object) oferta.precio_oferta));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@status_oferta", (object) oferta.status_oferta));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@fecha_ini", (object) oferta.fecha_ini));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@fecha_fin", (object) oferta.fecha_fin));
          sqLiteCommand.Parameters.Add(new SQLiteParameter("@last_sync", (object) oferta.last_sync));
          ((DbCommand) sqLiteCommand).ExecuteNonQuery();
          ((Component) sqLiteCommand).Dispose();
          GC.Collect();
        }
      }
      list.Clear();
      GC.Collect();
    }

    public void deleteOffers()
    {
      if (!"00:00".Equals(DateTime.Now.ToString("HH:mm")))
        return;
      SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM oferta WHERE status_oferta='cancelada' OR fecha_fin < @fecha_fin", pos_checker.getConnection());
      sqLiteCommand.Parameters.Add(new SQLiteParameter("@fecha_fin", (object) DateTime.Now));
      CtrlException.SetError(string.Format("Se eliminaron {0} ofertas", (object) ((DbCommand) sqLiteCommand).ExecuteNonQuery()));
      ((Component) sqLiteCommand).Dispose();
      GC.Collect();
    }

    private string getLastChangeDateTimeItems()
    {
      SQLiteDataReader data = pos_checker.GetData("SELECT strftime('%Y-%m-%d %H:%M:%f',last_sync) last_sync FROM articulo ORDER BY last_sync DESC LIMIT 1");
      return ((DbDataReader) data).Read() ? ((DbDataReader) data)["last_sync"].ToString() : this.dateInitial;
    }

    private string getLastChangeDateTimeOffers()
    {
      SQLiteDataReader data = pos_checker.GetData("SELECT strftime('%Y-%m-%d %H:%M:%f',last_sync) last_sync FROM oferta ORDER BY last_sync DESC LIMIT 1");
      return ((DbDataReader) data).Read() ? ((DbDataReader) data)["last_sync"].ToString() : this.dateInitial;
    }
  }
}
