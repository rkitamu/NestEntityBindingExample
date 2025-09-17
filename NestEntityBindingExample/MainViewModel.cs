using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace NestEntityBindingExample
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly List<User> _originalUsers;

        [ObservableProperty]
        private ObservableCollection<UserViewModel> _users;

        [ObservableProperty]
        private UserViewModel? _selectedUser;

        public MainViewModel()
        {
            _originalUsers = new List<User>
            {
                new User
                {
                    Id = 101,
                    Name = "Taro Suzuki",
                    Description = "He is a software engineer."
                },
                new User
                {
                    Id = 102,
                    Name = "Hanako Yamada",
                    Description = "She is a designer."
                },
                new User
                {
                    Id = 103,
                    Name = "Jiro Sato",
                    Description = "He is a project manager."
                }
            };

            _users = new ObservableCollection<UserViewModel>(
                _originalUsers.Select(u => new UserViewModel(u.Clone()))
            );
            _selectedUser = _users.FirstOrDefault();
        }

        [RelayCommand]
        private void Reset()
        {
            Users = new ObservableCollection<UserViewModel>(
                _originalUsers.Select(u => new UserViewModel(u.Clone()))
            );
            SelectedUser = Users.FirstOrDefault();
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void Delete(UserViewModel? userToDelete)
        {
            if (userToDelete != null)
            {
                Users.Remove(userToDelete);
            }
        }

        private bool CanDelete(UserViewModel? user)
        {
            return user != null;
        }
    }
}