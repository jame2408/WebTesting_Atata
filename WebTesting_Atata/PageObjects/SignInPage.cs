using Atata;
using WebTesting_Atata.Controls;

namespace WebTesting_Atata.PageObjects
{
    [Url("signin")]
    public class SignInPage : Page<SignInPage>
    {
        [FindByLabel]
        public TextInput<SignInPage> Email { get; init; }
        
        [FindById("password")]
        public PasswordInput<SignInPage> Password { get; init; }
        
        public Button<SignInPage> SignIn { get; init; }

        public ValidationMessageList<SignInPage> ValidationMessages { get; init; }
    }
}