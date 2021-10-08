
namespace Single
{
    class Email {

        public string Username { get; set; }
        public string Password { get; set; }

        public Email(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    class Login
    {
        static public bool isLogin(Email email)
        {
            if(!String.IsNullOrWhiteSpace(email.Username) && !String.IsNullOrWhiteSpace(email.Password)) return true;
            
            return false;
        }
    }


    class Program
    {
        static void Main()
        {
            var email_1 = new Email("ZAZA","123");
            var email_2 = new Email("ZAZA","");
            Console.WriteLine(Login.isLogin(email_1));
            Console.WriteLine(Login.isLogin(email_2));
        }
    }

}


    






