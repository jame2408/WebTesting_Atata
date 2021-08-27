using System;
using Atata;
using NUnit.Framework;
using WebTesting_Atata.PageObjects;

namespace WebTesting_Atata
{
    public class SignInTests : UiTestFixture
    {
        [Test]
        public void Validation_Required()
        {
            Go.To<SignInPage>()
                .SignIn.Click()
                .ValidationMessages[x => x.Email].Should.Equal("is required")
                .ValidationMessages[x => x.Password].Should.Equal("is required");
        }
        
        [Test]
        public void Validation_InvalidPassword()
        {
            Go.To<SignInPage>()
                .PageUri.Should.Equal(new Uri(Config.BaseUrl + "signin"))
                .Email.Set(Config.Account.Email)
                .Password.Set("wrong password")
                .SignIn.Click()
                .ValidationMessages.Should.Contain(TermMatch.Contains, "invalid")
                .Password.Set(Config.Account.Password)
                .SignIn.Click()
                .PageUri.Should.Equal(new Uri(Config.BaseUrl + "users"));
        }
    }
}