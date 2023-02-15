using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAcessandoAppSettings1.Services
{
    public class TextoMensagemService : IMensagemService
    {
        public string GetMensagem()
        {
            return "Texto de Mensagem";
        }
    }
}
