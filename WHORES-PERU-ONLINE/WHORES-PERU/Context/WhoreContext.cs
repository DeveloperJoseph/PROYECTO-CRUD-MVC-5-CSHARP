using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WHORES_PERU.Models;

namespace WHORES_PERU.Context
{
    public class WhoreContext:DbContext
    {
        public DbSet<Whore> Whores { get; set; }
    }
}