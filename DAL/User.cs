using System;
using System.Collections.Generic;

namespace MVCUserLogin.DAL;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? Age { get; set; }

    public string? MobileNumber { get; set; }

    public string? Password { get; set; }
}
