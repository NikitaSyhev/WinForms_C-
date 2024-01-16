using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutorisationExample
{
    enum Roles
    {
        Administrator,
        User,
       
    }

    enum Position
    {
        Director,
        Manager,
        Worker
    }
    internal class User
    {
        private string name;
        private int password;
        private Roles role;
        private Position position;



        public string Name { get { return name; } }
        public int Password { get { return password; } }
        public Roles Role { get { return role; } set { role = value; } }
        public Position Position { get { return position; } set { position = value; } }

        public User(string name, int password, Roles role = Roles.User, Position position = Position.Worker)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            Position = position;
        }

    }
}
