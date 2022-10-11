using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawelin.App.Infrastructure.Models
{
    public class TabView
    {
        public String Name { get; set; }
        public RenderFragment Content { get; set; }
        public Guid Id { get; set; }

    }
}
