using DL;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        private readonly JguevaraProgramacionNcapasFebreroContext _context;

        public Usuario(JguevaraProgramacionNcapasFebreroContext context)
        {
            _context = context;
        }

        public static void Carlos() { }

        public static void HolaMundo()
        {
              
        }

        public static void NoAviso() { }
    }
}
