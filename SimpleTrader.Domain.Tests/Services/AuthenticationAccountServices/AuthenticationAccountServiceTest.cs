using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;
using SimpleTrader.Domain.Exceptions;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Tests.Services.AuthenticationAccountServices
{
    [TestFixture]
    public class AuthenticationAccountServiceTest
    {
        private Mock<IPasswordHasher> _mockPasswordHasher;
        private Mock<IAccountService> _mockAccountService;
        private AuthenticationAccountService testService;
        [SetUp]
        public void SetUp()
        {
            _mockPasswordHasher = new Mock<IPasswordHasher>();
            _mockAccountService = new Mock<IAccountService>();
            testService = new AuthenticationAccountService(_mockAccountService.Object, _mockPasswordHasher.Object);
        }

        [Test]
        public async Task Login_WithCorrectPasswordForExistingUsername_ReturnsAccountForCorrectUsername()
        {
            string expectedUsername = "usernametest";
            string password = "usernametest";
            _mockAccountService.Setup(s => s.GetByUserName(expectedUsername)).ReturnsAsync(new Account() { AccountHolder = new User() { Username = expectedUsername} });
            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(It.IsAny<string>(), password)).Returns(PasswordVerificationResult.Success);

            Account account = await testService.Login(expectedUsername, password);

            string actualUsername = account.AccountHolder.Username;
            Assert.AreEqual(expectedUsername, actualUsername);
        }


        [Test]
        public void Login_WithTheIncorrectPasswordForExcistingUser_ThrowInvalidExceptionPasswordForExcistingUser()
        {
            //Arrange
            string ExpectedUsername = "usernametest";
            string ExpectedPassword = "passwordtest";

            _mockAccountService.Setup(s => s.GetByUserName(ExpectedUsername)).ReturnsAsync(
                new Account()
                {
                    AccountHolder =
                new User()
                { Username = ExpectedUsername }
                });

            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(It.IsAny<string>(), ExpectedPassword)).Returns(PasswordVerificationResult.Failed);


            //Act
            InvalidPasswordException exception = Assert.ThrowsAsync<InvalidPasswordException>(() => testService.Login(ExpectedUsername, ExpectedPassword));

            //Assert
            string ActualUserName = exception.Username;
            Assert.AreEqual(ExpectedUsername, ActualUserName);
        }

        [Test]
        public void Login_WithNonExcistingUser_ThrowInvalidExceptionPasswordForExcistingUser()
        {
            //Arrange
            string ExpectedUsername = "usernametest";
            string ExpectedPassword = "passwordtest";


            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(It.IsAny<string>(), ExpectedPassword)).Returns(PasswordVerificationResult.Failed);


            //Act
            UserNotFoundException exception = Assert.ThrowsAsync<UserNotFoundException>(() => testService.Login(ExpectedUsername, ExpectedPassword));

            //Assert
            string ActualUserName = exception.Username;
            Assert.AreEqual(ExpectedUsername, ActualUserName);
        }

    }
}

