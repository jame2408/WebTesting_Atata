using Atata.Configuration.Json;

namespace WebTesting_Atata
{
    public class AtataConfig : JsonConfig<AtataConfig>
    {
        public AccountConfiguration Account { get; init; }

        public class AccountConfiguration
        {
            public string Email { get; init; }

            public string Password { get; init; }
        } 
    }
}