﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    public class Estado
    {
        public enum EstadoCursada
        {
            NO_INICIADO,
            CANCELADO,
            INICIADO,
            TERMINADO
        };

        public int estadoActual;
    }
}
