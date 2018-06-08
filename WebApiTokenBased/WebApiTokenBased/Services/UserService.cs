namespace WebApiTokenBased.Services
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class UserService
    {
        public User ValidateUser(string email, string password)
        {
            var userList = GetUserList();
            var user = userList.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }
        public List<User> GetUserList()
        {
            return new List<User>{
                new User() {Id=1,Name="Rajesh",Email="rajesh@test.com",Password="password"},
                new User() {Id=2,Name="Praveen",Email="praveen@test.com",Password="password"}
                            };


        }
    }
}