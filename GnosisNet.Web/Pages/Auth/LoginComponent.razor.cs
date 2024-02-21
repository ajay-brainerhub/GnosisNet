﻿using GnosisNet.Web.Models;
using Microsoft.AspNetCore.Components;

namespace GnosisNet.Web.Pages.Auth
{
    public partial class LoginComponent
    {
        private LoginRequestDto loginModel = new LoginRequestDto();
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private string errorMessage;
        private async Task HandleSubmit()
        {
            try
            {
                var loginResponse = await _authService.Login(loginModel);
                if(loginResponse.Token == null)
                {
                }
                else
                {                    
                    NavigationManager.NavigateTo("/myblogs");
                }
            }
            catch (Exception ex)
            {
                errorMessage = "An error occurred while processing your request.";
                // Log the exception or handle it as needed
            }
        }
    }
}
