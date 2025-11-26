using Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StrategyFactory
    {
        private readonly EnvioCorreo _correo;
        private readonly EnvioMoto _moto;
        private readonly EnvioRetiro _retiro;

        public StrategyFactory(EnvioMoto moto, EnvioCorreo correo, EnvioRetiro retiro)
        {
            _moto = moto;
            _correo = correo;
            _retiro = retiro;
        }

        public IEnvioStrategy FromAlias(string alias)
        {
            return alias switch
            {
                "moto" => _moto,
                "correo" => _correo,
                "retiro" => _retiro,
                _ => throw new ArgumentException("Tipo de envio no reconocido. Usa: moto | correo | retiro")
            };
        }

    }
}
