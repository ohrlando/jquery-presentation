using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQuery_Presentation_Demo1_Proj.Models
{
    public class Person
    {
        public string Nome { get; set; }

        private int _Idade;
        public int Idade { get
            {
                return _Idade;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Idade incorreta");
                }
                _Idade = value;
            }
        }
        public string SobreNome { get; set; }

        [JsonIgnore]
        public string NomeCompleto { get
            {
                return $"{Nome} {SobreNome}";
            }
        }
    }
}