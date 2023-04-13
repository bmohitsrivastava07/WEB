//using DatabaseLayer;
//using DatabaseLayer.Operations;
//using Microsoft.EntityFrameworkCore.Storage;

//namespace BusinessLayer
//{
//    public class Business
//    {
//        TodoOperation todo = new TodoOperation();
//        TodolistOperation todolist = new TodolistOperation();
//        public List<string> GetProfile_B()
//        {
//            return todo.GetProfile();
//        }
//        public string PostProfile_B(string Name, int Age, string Email, string PhoneNo)
//        {
//            return todo.PostProfile(Name,Age,Email,PhoneNo);
//        }
//        public List<string> Getlist_B()
//        {
//            return todolist.GetList();
//        }
//        public string Postlist_B(string TodoId, string TodoDescription, string TodoStatus, string Email)
//        {
//            return todolist.PostList(TodoId, TodoDescription, TodoStatus, Email);
//        }
//    }
//}