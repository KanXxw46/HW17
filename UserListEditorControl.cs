using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;

namespace HW__17
{
    public partial class UserListEditorControl : UserControl
    {
        ObservableCollection<User> _users = null;

        public UserListEditorControl()
        {
            InitializeComponent();

            _users = Database.GetUsers();
            UsersDataGrid.ItemsSource = _users;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public void AddUser()
        {
            Database.Add(User user);
        }
    }
}
