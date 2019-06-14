using System.Collections.Generic;

namespace SGM.AplicationCore.Entity
{
    public class PessoaTipo
    {
        public PessoaTipo()
        {

        }

        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
