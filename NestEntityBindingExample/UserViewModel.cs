using CommunityToolkit.Mvvm.ComponentModel;

namespace NestEntityBindingExample
{
    public partial class UserViewModel : ObservableObject
    {
        private readonly User _inner;
        public int Id
        {
            get => _inner.Id;
            set => SetProperty(_inner.Id, value, _inner, (u, v) => u.Id = v);
        }

        public string Name
        {
            get => _inner.Name;
            set => SetProperty(_inner.Name, value, _inner, (u, v) => u.Name = v);
        }

        public string Description
        {
            get => _inner.Description;
            set => SetProperty(_inner.Description, value, _inner, (u, v) => u.Description = v);
        }

        public UserViewModel(User user)
        {
            _inner = user;
        }

        public static UserViewModel FromUser(User user)
        {
            return new UserViewModel(user);
        }
    }
}