// Decompiled with JetBrains decompiler
// Type: POSChecker.MainProgram
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using POSChecker.View;
using System;
using System.Windows.Forms;

namespace POSChecker
{
  internal static class MainProgram
  {
    [MTAThread]
    private static void Main() => Application.Run((Form) new PriceForm());
  }
}
