using System;
using System.Collections.Generic;

namespace RetornoNotas
{
    //As classes abaixo foram geradas através do site https://json2csharp.com/

    public class Paginacao
    {
        public int numeroDeNotas { get; set; }
        public int mumeroDePaginas { get; set; }
        public int pagina { get; set; }
    }

    public class Nota
    {
        public string id { get; set; }
        public string nsu { get; set; }
        public string tipo { get; set; }
        public string chave { get; set; }
        public string numero { get; set; }
        public string serie { get; set; }
        public string emitente { get; set; }
        public double valor { get; set; }
        public DateTime dataEmissao { get; set; }
        public bool download { get; set; }
        public string xml { get; set; }
        public DateTime criadoEm { get; set; }
        public DateTime atualizadoEm { get; set; }
    }

    public class Root
    {
        public string protocolo { get; set; }
        public string situacao { get; set; }
        public string mensagem { get; set; }
        public Paginacao paginacao { get; set; }
        public List<Nota> notas { get; set; }
    }
}
