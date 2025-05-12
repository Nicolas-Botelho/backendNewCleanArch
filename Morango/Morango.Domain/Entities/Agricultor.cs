using ConectaFapes.Common.Domain.BaseEntities;
using Morango.Domain.Enums;
using Morango.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace Morango.Domain.Entities
    {

    public  class Agricultor : BaseEntity {

      public string Nome { get; set; }
      public String Identification { get; set; }
      public String Email_x { get; set; }
      public string Telefone { get; set; }
      public Byte[] Foto { get; set; }
      //OneToMany
      public ICollection<Propriedade>? Propriedades { get; set;}





    public Agricultor()
        {
        }
    public Agricultor(string nome,String identification,String email_x,string telefone,Byte[] foto)
        {

          var validationErrors = AgricultorValidation(nome,identification,email_x,telefone,foto);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Nome = nome;
          Identification = identification;
          Email_x = email_x;
          Telefone = telefone;
          Foto = foto;





        }

    private List<string>AgricultorValidation(string nome,String identification,String email_x,string telefone,Byte[] foto)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
