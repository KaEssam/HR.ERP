namespace HR.ERP.API.Dtos
{
    public class LoginDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class AuthResponseDto
    {
        public string Token { get ; set; }

        public string Email { get; set; }

        public DateTime Expiration { get; set; }

    }
}
