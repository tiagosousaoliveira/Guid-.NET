using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGUIDmodificado
{
    public class ModificacaoGuid
    {
        public static String modficandoguid()
        {
            string gu ="";
            for (int i = 0; i < 4; i++)
            {
                Guid guid = Guid.NewGuid();
                var gui = guid.ToString("X");

                gu += gui;
            }

            return gu.Substring(0,100);
        }
    }
}
