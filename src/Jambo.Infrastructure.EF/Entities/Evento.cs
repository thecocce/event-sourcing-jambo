﻿using System;
using Jambo.Core.Interfaces.Entities;
using System.Collections.Generic;

namespace Jambo.Infrastructure.EF.Entities
{
    public class Evento : IEvento
    {
        public Guid ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRealizacao { get; set; }

        public virtual ICollection<Lote> LotesNavigation { get; set; }
    }
}
