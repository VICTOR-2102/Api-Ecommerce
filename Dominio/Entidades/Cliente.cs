﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
  public class Cliente : Base 
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CPFCNPJ { get; set; }
        public string Endereco { get; set; }
        public string DataDeNascimento { get; set; }
        public string Sexo { get; set; }

       
    }
}
