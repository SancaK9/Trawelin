﻿using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;


namespace BlazorHero.CleanArchitecture.Client.Shared.Components
{
    public partial class UserCard
    {

        [Parameter] public string Class { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string Email { get; set; }
        private char FirstLetterOfName { get; set; }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await LoadDataAsync();
            }
        }

        private async Task LoadDataAsync()
        {
          
            
        }
    }
}