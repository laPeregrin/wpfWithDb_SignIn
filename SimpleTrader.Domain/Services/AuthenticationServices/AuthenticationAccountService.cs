using Microsoft.AspNet.Identity;
using SimpleTrader.Domain.Exceptions;
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

            if (storedAccount == null)
            {
                throw new UserNotFoundException(username);
            }

            PasswordVerificationResult passwordResult = _hasher.VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedAccount;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (!password.Equals(confirmPassword))
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }
            Account emailUser = await _accountService.GetByEmail(email);
            if(emailUser != null)
            {
                result = RegistrationResult.EmailAlreadyExist;
            }
            Account userName = await _accountService.GetByUserName(username);
            if(userName != null)
            {
                result = RegistrationResult.UserNameAlreadyExists;
            }
            if(result==RegistrationResult.Success)
            {
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
            }
            return result;
        }

        
    }
}
