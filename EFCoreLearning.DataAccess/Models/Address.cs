using System;
using System.Collections.Generic;

namespace EFCoreLearning.DataAccess.Models;

public partial class Address
{
    public string HseId { get; set; } = null!;

    public string? Pin { get; set; }

    public string? Pind { get; set; }

    public string? HseNbr { get; set; }

    public string? HseFracNbr { get; set; }

    public string? HseDirCd { get; set; }

    public string? StrNm { get; set; }

    public string? StrSfxCd { get; set; }

    public string? StrSfxDirCd { get; set; }

    public string? UnitRange { get; set; }

    public string? ZipCd { get; set; }

    public string? Lat { get; set; }

    public string? Lon { get; set; }

    public string? XCoordNbr { get; set; }

    public string? YCoordNbr { get; set; }

    public string? AsgnSttsInd { get; set; }

    public string? EngDist { get; set; }

    public string? CnclDist { get; set; }
}
