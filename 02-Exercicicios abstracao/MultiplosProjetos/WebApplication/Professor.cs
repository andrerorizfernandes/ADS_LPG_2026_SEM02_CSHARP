using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public int CargaHoraria { get; set; }

        public Professor(string nome, string disciplina, int cargaHoraria)
        {
            Nome = nome;
            Disciplina = disciplina;
            CargaHoraria = cargaHoraria;
        }

        public Professor(int cargaHoraria)
        {
            CargaHoraria = (cargaHoraria * 2);
        }

        public Professor()
        {
         
        }
    }
}