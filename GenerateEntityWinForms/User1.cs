using System;
using System.Collections.Generic;

namespace GenerateEntityWinForms;

public partial class User1
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string Login { get; set; } = null!;

    public virtual ICollection<UserInfoV1> UserInfoV1s { get; } = new List<UserInfoV1>();

    public virtual ICollection<UserInfoV2> UserInfoV2s { get; } = new List<UserInfoV2>();
}
