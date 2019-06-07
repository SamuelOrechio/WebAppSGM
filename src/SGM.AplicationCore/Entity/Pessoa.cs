using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.AplicationCore.Entity
{
  public  class Pessoa
    {
        public int PessoaId { get; set; }
        public int PessoaTipoId { get; set; }
        public virtual PessoaTipo PessoaTipo { get; set; }
    }
}
