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

        private readonly IAccountService _accountService;
        private readonly IPasswordHasher _hasher;

        public AuthenticationAccountService(IAccountService accountService, IPasswordHasher passwordHasher)
        {
            _hasher = new PasswordHasher();
            _accountService = accountService;
        }



        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await _accountService.GetByUserName(username);
            PasswordVerificationResult passswordsRsult = _hasher.VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);
            if (passswordsRsult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException();
            }
            return storedAccount;
        }

        public async Task<bool> Register(string email, string username, string password, string confirmPassword)
        {
            bool success = false;
            if (password.Equals(confirmPassword))
            {
                throw new Exception();
            }
            Account emailUser = await _accountService.GetByEmail(email);
            if(emailUser != null)
            {
                throw new Exception();
            }
            Account userName = await _accountService.GetByUserName(username);
            if(userName != null)
            {
                throw new Exception();
            }
            string hashedPassword = _hasher.HashPassword(password);

            User user = new User()
            {

                Email = email,
                Username = username,
                PasswordHash = hashedPassword,
                DatedJoined = DateTime.Now

            };
            Account account = new Account()
            {
                AccountHolder = user
            };
            await _accountService.Create(account);


            return success;
        }
    }
}
