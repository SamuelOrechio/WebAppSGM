using SGM.AplicationCore.Entity;
using System.Linq;

namespace SGM.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.PessoaTipos.Any())
            {
                return;
            }

            var PessoaTipo = new PessoaTipo[]
            {
                new PessoaTipo
                {
                    Descricao = "Pessoa Física"
                },

                new PessoaTipo
                {
                    Descricao = "Pessoa Jurídica"
                }
            };
            context.AddRange(PessoaTipo);
            context.SaveChanges();
        }
    }
}
