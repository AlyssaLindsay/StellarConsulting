﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Stellar.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
