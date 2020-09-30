using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationAccountService authenticationService;

        public Authenticator(IAuthenticationAccountService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public Account CurrentAccount { get; private set; }
        public bool IsLoggedIn => CurrentAccount != null;

        public async Task<bool> Login(string username, string password)
        {
            bool success = true;
            try
            {
                CurrentAccount = await authenticationService.Login(username, password);

            }
            catch
            {
                success = false;
                throw new Exception();
            }

            return success;
        }

        public void Logout()
        {
            CurrentAccount = null;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            return await authenticationService.Register(email, username, password, confirmPassword);
        }
    }
}
