using Domain;
using Newtonsoft.Json;
using System;

namespace Infraestructura
{
    public class ActivoModel
    {
        public ActivoFijo[] activos;

        private void Add(ActivoFijo p)
        {
            Add(p, ref activos);
        }
        public string GetActivosJson()
        {
            return JsonConvert.SerializeObject(activos);
        }
        private void Add(ActivoFijo p, ref ActivoFijo[] pds)
        {
            if (pds == null)
            {
                pds = new ActivoFijo[1];
                pds[pds.Length - 1] = p;
                return;
            }
            ActivoFijo[] tmp = new ActivoFijo[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
    }
}
