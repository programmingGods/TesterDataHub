using System;
using System.Collections.Generic;

namespace GenerateEntityWinForms;

public partial class InfoV1
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public string? Value { get; set; }

    public virtual ICollection<UserInfoV1> UserInfoV1s { get; } = new List<UserInfoV1>();
}
