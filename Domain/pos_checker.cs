// Decompiled with JetBrains decompiler
// Type: POSChecker.Domain.pos_checker
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace POSChecker.Domain
{
  public class pos_checker
  {
    private static SQLiteConnection cnx;
    private static SQLiteCommand sqlcmd;
    private static string stringConnection = "Data Source =" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\pos_checker.s3db;Read Only=false";

    protected static SQLiteConnection getConnection()
    {
      pos_checker.sqlcmd = (SQLiteCommand) null;
      try
      {
        if (pos_checker.cnx == null)
        {
          pos_checker.cnx = new SQLiteConnection(pos_checker.stringConnection);
          ((DbConnection) pos_checker.cnx).Open();
        }
      }
      catch
      {
        pos_checker.cnx = (SQLiteConnection) null;
        throw new Exception("No se puede conectar con el servidor.");
      }
      return pos_checker.cnx;
    }

    public static SQLiteDataReader GetData(string sqlCommand)
    {
      pos_checker.sqlcmd = new SQLiteCommand(sqlCommand, pos_checker.getConnection());
      return pos_checker.sqlcmd.ExecuteReader();
    }

    public static void ExecuteSQL(string sqlCommand)
    {
      pos_checker.sqlcmd = new SQLiteCommand(sqlCommand, pos_checker.getConnection());
      ((DbCommand) pos_checker.sqlcmd).ExecuteNonQuery();
    }

    public static void CloseConnection()
    {
      if (pos_checker.cnx == null)
        return;
      ((DbConnection) pos_checker.cnx).Close();
      pos_checker.cnx.Dispose();
      pos_checker.cnx = (SQLiteConnection) null;
    }
  }
}
