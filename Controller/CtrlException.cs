// Decompiled with JetBrains decompiler
// Type: POSChecker.Controller.CtrlException
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System;
using System.IO;
using System.Reflection;

namespace POSChecker.Controller
{
  public class CtrlException
  {
    private static string fileName = string.Format("{0}\\error.log", (object) Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase));

    public static void SetError(string msg)
    {
      if (!File.Exists(CtrlException.fileName))
        File.Create(CtrlException.fileName).Dispose();
      TextWriter textWriter = (TextWriter) new StreamWriter(CtrlException.fileName, true);
      textWriter.WriteLine(string.Format("{0} - {1}", (object) DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), (object) msg));
      textWriter.Close();
    }
  }
}
