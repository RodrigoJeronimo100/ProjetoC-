﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    internal class Estudante: Cliente
    {
        [Key]

        public int NumEstudante { get; set; }
        
        public Estudante (string nomeUtilizador, int nifUtilizador, int saldo, int numEstudante) : base(nomeUtilizador, nifUtilizador, saldo)
        {
            NumEstudante = numEstudante;
        }

        public Estudante()
        {
            // Construtor vazio necessário para o Entity Framework
        }

    }
}