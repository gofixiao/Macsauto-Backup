namespace Macsauto.Domain
{
    public class User : Entity
    {
        private string _username;
        private string _password;
        private Employee _employee;

        protected User(){}

        public User(Employee employee, string username, string password)
        {
            _username = username;
            _password = password;
            _employee = employee;
        }

        public virtual string Username
        {
            protected set { _username = value; }
            get { return _username; }
        }

        public virtual string Password
        {
            protected set { _password = value; }
            get { return _password; }
        }

        public virtual Employee Employee
        {
            protected set { _employee = value; }
            get { return _employee; }
        }

        public override string ToString()
        {
            return _username;
        }
    }
}