// Decompiled with JetBrains decompiler
// Type: POSChecker.Properties.Resources
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace POSChecker.Properties
{
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) POSChecker.Properties.Resources.resourceMan, (object) null))
          POSChecker.Properties.Resources.resourceMan = new ResourceManager("POSChecker.Properties.Resources", typeof (POSChecker.Properties.Resources).Assembly);
        return POSChecker.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => POSChecker.Properties.Resources.resourceCulture;
      set => POSChecker.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap bg_barcode => (Bitmap) POSChecker.Properties.Resources.ResourceManager.GetObject(nameof (bg_barcode), POSChecker.Properties.Resources.resourceCulture);
  }
}
