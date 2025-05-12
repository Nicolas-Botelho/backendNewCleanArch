using ConectaFapes.Common.Domain.BaseEntities;
using Morango.Domain.Enums;
using Morango.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace Morango.Domain.Entities
    {

    public  class Propriedade : BaseEntity {

      public string Nome { get; set; }
      public string Distrito { get; set; }
      //ManyToOne
      public Agricultor? Agricultor { get; set; }
      public Guid PropriedadeAgricultorId {get; set; }





    public Propriedade()
        {
        }
    public Propriedade(string nome,string distrito, Guid agricultorId)
        {

          var validationErrors = PropriedadeValidation(nome,distrito, agricultorId);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Nome = nome;
          Distrito = distrito;
          PropriedadeAgricultorId = agricultorId;





        }

    private List<string>PropriedadeValidation(string nome,string distrito, Guid agricultorId)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
