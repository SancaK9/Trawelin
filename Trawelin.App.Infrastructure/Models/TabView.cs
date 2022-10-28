using Microsoft.AspNetCore.Components;

namespace Trawelin.App.Infrastructure.Models
{
    public class TabView
    {
        public String Name { get; set; }
        public RenderFragment Content { get; set; }
        public Guid Id { get; set; }
    }
}
