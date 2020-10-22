using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HW__17
{
    public static class Database
    {
        static ObservableCollection<User> _users = null; 


        public static ObservableCollection<User> GetUsers()
        {
            _users = new ObservableCollection<User>();
            ReadData(); 
            return _users;
        }

        private static void ReadData()
        {
            throw new NotImplementedException();
        }

        public static void Add(User user)
        {
            _users.Add(user);
            SaveData(); 
        }

        private static void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
