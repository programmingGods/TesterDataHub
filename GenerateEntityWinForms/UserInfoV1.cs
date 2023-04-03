using System;
using System.Collections.Generic;

namespace GenerateEntityWinForms;

public partial class UserInfoV1
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long InfoId { get; set; }

    public virtual InfoV1 User { get; set; } = null!;

    public virtual User1 UserNavigation { get; set; } = null!;
}
