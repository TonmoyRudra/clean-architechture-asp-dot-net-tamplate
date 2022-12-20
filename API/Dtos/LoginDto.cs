namespace API.Dtos
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginDtoHRIS
    {
        public string ID { get; set; }
        public string CD { get; set; }
    }
}
