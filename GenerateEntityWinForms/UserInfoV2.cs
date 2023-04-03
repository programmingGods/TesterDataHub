using System;
using System.Collections.Generic;

namespace GenerateEntityWinForms;

public partial class UserInfoV2
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public virtual User1 User { get; set; } = null!;
}
