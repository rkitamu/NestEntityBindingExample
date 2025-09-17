using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace NestEntityBindingExample
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<UserViewModel> _users;

        [ObservableProperty]
        private UserViewModel? _selectedUser;

        public MainViewModel()
        {
            var userModels = new[]
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

            _users = new ObservableCollection<UserViewModel>(userModels.Select(u => new UserViewModel(u)));
            _selectedUser = _users.FirstOrDefault();
        }
    }
}