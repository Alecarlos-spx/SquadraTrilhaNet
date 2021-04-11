using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Aula2ExemploCrud.Validator.Medico
{
    public class AdicionarMedicoRequestValidator
    {
   

        public AdicionarMedicoResponse ValidarCamposAdicionarMedico(AdicionarMedicoRequest request)
        {
            var response = new AdicionarMedicoResponse();
            List<string> erros = new List<string>();
            

            if (request.nome.Length < 20 && request.nome.Length > 3)
            {
                erros.Add("Nome deve conter de 3 a 20 caracteres");
                
            }

            

            Regex expressao = new Regex(@"(\([0-9]{2}\)|)[0-9]{4,5}-[0-9]{4}");

            //Match(request.telefone, expressao);
            //request.telefone.Length <= 10 || 
            if (!expressao.IsMatch(request.telefone.ToString()))
            {
                erros.Add("Telefone numero de digitos incorretos. Ex. 12345-1234 ");
            }

            if(request.crm.Length != 10)
            {
                erros.Add("CRM deve conter 10 digitos.");
            }

            if (request.especialidade.Length > 40 || request.especialidade.Length < 3)
            {
                erros.Add("Especialidade deve conter 3 a 40 digitos.");
            }

            foreach (var item in erros)
            {
                response.erros.Add(item);

            }

           
            return response;
        

        }
        
    }
}
