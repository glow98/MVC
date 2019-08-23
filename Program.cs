using System;
using System.Collections;
using MVC.Model;
using MVC.View;
using MVC.Controller;

namespace UseMVCApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            UsersView view = new UsersView();
 
            IList users = new ArrayList();

            users.Add(new User("Vladimir", "Putin",
                 "122", "Gobernador de Russia",
                User.SexOfPerson.Male));
            users.Add(new User("Barack", "Obama",
                 "123", "Gobernador de USA",
                 User.SexOfPerson.Male));
            users.Add(new User("Stephen", "Harper",
                "124", "Gobernador de Canada",
                User.SexOfPerson.Male));
            users.Add(new User("Jean", "Charest",
                "125", "Gobernador de Quebec",
                 User.SexOfPerson.Male));
            users.Add(new User("David", "Cameron",
                "126", "Gobernador de United Kingdom",
                User.SexOfPerson.Male));
            users.Add(new User("Angela", "Merkel",
                "127", "Gobernador de Alemania",
                User.SexOfPerson.Female));
            users.Add(new User("Nikolas", "Sarkozy",
                "128", "Gobernador de Francia",
                User.SexOfPerson.Male));
            users.Add(new User("Silvio", "Berlusconi",
                "129", "Gobernador de Italia",
                User.SexOfPerson.Male));
            users.Add(new User("Yoshihiko", "Noda",
                "130", "Gobernador de Japon",
                User.SexOfPerson.Male));

            UsersController controller = new UsersController(view, users);
            controller.LoadView();
        }
    }
}
