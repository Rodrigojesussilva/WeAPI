﻿using System;
using System.Collections.Generic;

namespace ProjetoWebAPI.ORM;

public partial class TbUsuario
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Senha { get; set; } = null!;
}
