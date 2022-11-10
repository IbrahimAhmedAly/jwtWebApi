namespace jwtWebApi.Models
{
    public interface IAuth
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
