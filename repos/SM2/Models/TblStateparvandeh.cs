using System;
using System.Collections.Generic;

namespace SM2.Models;

public partial class TblStateparvandeh
{
    public decimal Id { get; set; }

    public decimal? Codeparvandeh { get; set; }

    public string? Codemadesad { get; set; }

    public string? Date { get; set; }

    public int? State { get; set; }

    public int? Idkarbar { get; set; }

    public string? Tozihat { get; set; }
}
