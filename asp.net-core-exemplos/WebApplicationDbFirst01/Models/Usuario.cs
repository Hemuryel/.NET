﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst01.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
