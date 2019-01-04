using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChangeMgmt.Tests
{
    using BusinessLogic.Helpers;
    using Common.DataWrapper.Wrappers;
    using Common.DTO;

    public class LoginTests
    {
        [Fact]
        public void CorrectPasswordLogin()
        {
            UserDTO user = new UserDTO("Tim", "password1");

            Assert.True(LoginHelper.IsUserPasswordCorrect(new DummyDataWrapper().UserNamesAndPasswords, user));  
        }

        [Fact]
        public void IncorrectPasswordLogin()
        {
            UserDTO user = new UserDTO("Tim", "myPassword");

            Assert.False(LoginHelper.IsUserPasswordCorrect(new DummyDataWrapper().UserNamesAndPasswords, user));
        }

        [Fact]
        public void UserDoesNotExist()
        {
            UserDTO user = new UserDTO("Timothy", "password1");

            Exception ex = Assert.Throws<ArgumentException>(() => LoginHelper.IsUserPasswordCorrect(new DummyDataWrapper().UserNamesAndPasswords, user));
            Assert.Equal($"No user exists with user name {user.UserName}", ex.Message);
        }
    }
}
