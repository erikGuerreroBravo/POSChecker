// Decompiled with JetBrains decompiler
// Type: POSChecker.Controller.ReadBarCode
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using Symbol.Barcode2;
using Symbol.Barcode2.Design;

namespace POSChecker.Controller
{
  public class ReadBarCode
  {
    private Symbol.Barcode2.Design.Barcode2 barcode21;

    public ReadBarCode()
    {
      this.barcode21 = new Symbol.Barcode2.Design.Barcode2();
      this.barcode21.Config.DecoderParameters.CODABAR = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.CODABARParams.ClsiEditing = false;
      this.barcode21.Config.DecoderParameters.CODABARParams.NotisEditing = false;
      this.barcode21.Config.DecoderParameters.CODABARParams.Redundancy = true;
      this.barcode21.Config.DecoderParameters.CODE128 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.CODE128Params.EAN128 = true;
      this.barcode21.Config.DecoderParameters.CODE128Params.ISBT128 = true;
      this.barcode21.Config.DecoderParameters.CODE128Params.Other128 = true;
      this.barcode21.Config.DecoderParameters.CODE128Params.Redundancy = false;
      this.barcode21.Config.DecoderParameters.CODE39 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.CODE39Params.Code32Prefix = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.Concatenation = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.ConvertToCode32 = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.FullAscii = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.Redundancy = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.ReportCheckDigit = false;
      this.barcode21.Config.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
      this.barcode21.Config.DecoderParameters.CODE93 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.CODE93Params.Redundancy = false;
      this.barcode21.Config.DecoderParameters.D2OF5 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.D2OF5Params.Redundancy = true;
      this.barcode21.Config.DecoderParameters.EAN13 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.EAN8 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
      this.barcode21.Config.DecoderParameters.I2OF5 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
      this.barcode21.Config.DecoderParameters.I2OF5Params.Redundancy = true;
      this.barcode21.Config.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
      this.barcode21.Config.DecoderParameters.I2OF5Params.VerifyCheckDigit = (I2OF5.CheckDigitSchemes) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.KOREAN_3OF5 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.KOREAN_3OF5Params.Redundancy = true;
      this.barcode21.Config.DecoderParameters.MSI = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.MSIParams.CheckDigitCount = (CheckDigitCounts) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.MSIParams.CheckDigitScheme = (CheckDigitSchemes) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.MSIParams.Redundancy = true;
      this.barcode21.Config.DecoderParameters.MSIParams.ReportCheckDigit = false;
      this.barcode21.Config.DecoderParameters.UPCA = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.UPCAParams.Preamble = (Preambles) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.UPCAParams.ReportCheckDigit = true;
      this.barcode21.Config.DecoderParameters.UPCE0 = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
      this.barcode21.Config.DecoderParameters.UPCE0Params.Preamble = (Preambles) (int) byte.MaxValue;
      this.barcode21.Config.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = (AIM_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = (AIM_TYPE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = (DPM_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = (FOCUS_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = (FOCUS_POSITION) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = (ILLUMINATION_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = (INVERSE1D_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = (LINEAR_SECURITY_LEVEL) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = (PICKLIST_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = (VIEWFINDER_FEEDBACK) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = (VIEWFINDER_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = (AIM_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = (AIM_TYPE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamWidth = (BEAM_WIDTH) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = (DBP_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = (LINEAR_SECURITY_LEVEL) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = (RASTER_MODE) (int) byte.MaxValue;
      this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = (DisabledEnabled) (int) byte.MaxValue;
      this.barcode21.Config.ScanParameters.BeepFrequency = 2670;
      this.barcode21.Config.ScanParameters.BeepTime = 200;
      this.barcode21.Config.ScanParameters.CodeIdType = (CodeIdTypes) (int) byte.MaxValue;
      this.barcode21.Config.ScanParameters.LedTime = 3000;
      this.barcode21.Config.ScanParameters.ScanType = (SCANTYPES) (int) byte.MaxValue;
      this.barcode21.Config.ScanParameters.WaveFile = "";
      this.barcode21.DeviceType = (DEVICETYPES) (int) byte.MaxValue;
      this.barcode21.EnableScanner = true;
    }

    public Symbol.Barcode2.Design.Barcode2 getReaderBarCode() => this.barcode21;
  }
}
