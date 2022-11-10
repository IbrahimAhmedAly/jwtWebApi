namespace jwtWebApi.Models
{
    public class AuthModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
