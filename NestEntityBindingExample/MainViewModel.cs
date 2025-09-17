using CommunityToolkit.Mvvm.ComponentModel;

namespace NestEntityBindingExample
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private UserViewModel _currentUser;

        public MainViewModel()
        {
            var userModel = new User
            {
                Id = 101,
                Name = "Taro Suzuki",
                Description = "He is a software engineer."
            };

            _currentUser = new UserViewModel(userModel);
        }
    }
}