using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGuid_e_Persistindo
{
    public class Mapping : EntityTypeConfiguration<User>
    {
        public Mapping()
        {
            ToTable("User");

            HasKey(x => x._id);
               
         //   Property(x => x._id)
          //      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            /**
             * Se quiser que o Entity Crie um GUID Para voce no banco de Dados o Property deve esta no lugar dos HasKey
             * **/

            Property(x => x.datacadastro)
                .IsRequired();

            Property(x => x.nome)
                .IsRequired();
        }
    }
}
