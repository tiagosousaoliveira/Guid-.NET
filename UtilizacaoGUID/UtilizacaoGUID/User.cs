using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGUID
{
    public class User
    {
        public Guid _id { get; set; }
        public string nome { get; set; }
        public DateTime dataderegistro { get; set; }
    }
}
