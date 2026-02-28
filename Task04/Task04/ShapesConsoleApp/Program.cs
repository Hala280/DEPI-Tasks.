using Shapes;

namespace Shapes
{
    public interface IShape
    {
        double Area { get; }
         void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; private set; }
        public double Area => Math.PI * Radius * Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius: {Radius}, Area: {Area}");
        }
    }

    public class Rectangle: IRectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Area => Width * Height;
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width: {Width}, height: {Height}, Area: {Area}");
        }

    }


   
}

namespace AuthenticationService
{
    public interface IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password);
        public bool AuthorizeUser(string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string _username;
        private string _password;
        private string role;
        public BasicAuthenticationService(string username, string password, string role)
        {
            _username = username;
            _password = password;
            this.role = role;
        }
        public bool AuthenticateUser(string userName, string passWord)
        {
            if (_username == null || _password == null)
            {
                Console.WriteLine("Username or password is null. Cannot authenticate user.");
                return false;
            }
            if (_username == userName && _password == passWord)
            {
                Console.WriteLine("User authenticated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Authentication failed. Invalid username or password.");
                return false;
            }
        }
        public bool AuthorizeUser(string role)
        {
            if (this.role == null)
            {
                Console.WriteLine("User role is null. Cannot authorize user.");
                return false;
            }
            if (this.role == role)
            {
                Console.WriteLine("User authorized successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Authorization failed. User does not have the required role.");
                return false;
            }
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***********Question1 DEMO***********");
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();

            Console.WriteLine("***********Question2 DEMO***********");
            IAuthenticationService authService = new BasicAuthenticationService("admin", "password123", "admin");
            authService.AuthenticateUser("admin", "password123");
            authService.AuthenticateUser("admin", "wrongpassword");
            authService.AuthorizeUser("admin");



        }
    }
}