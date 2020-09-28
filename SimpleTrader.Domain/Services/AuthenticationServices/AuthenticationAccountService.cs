using Microsoft.AspNet.Identity;
using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services.AuthenticationServices
{
    public class AuthenticationAccountService : IAuthenticationAccountService
    {
        private readonly IDataService<Account> _accountService;



        public AuthenticationAccountService(IDataService<Account> accountService)
        {
            _accountService = accountService;
        }



        public Task<Account> Login(string sername, string assword)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Register(string email, string username, string password, string confirmPassword)
        {
            bool success = false;
            if (password.Equals(confirmPassword))
            {
                
                IPasswordHasher hasher = new PasswordHasher();
                string hashedPassword = hasher.HashPassword(password);

                User user = new User()
                {

                    Email = email,
                    Username = username,
                    PasswordHash = hashedPassword
                };
                Account account = new Account()
                {
                    AccountHolder = user
                };
                await _accountService.Create(account);
            }

            return success;
        }
    }
}
