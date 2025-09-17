using System.Diagnostics;

namespace NestEntityBindingExample
{
    public class User
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                int oldValue = _id;
                _id = value;
                Debug.WriteLine($"User.Id changed: '{oldValue}' -> '{_id}'");
            }
        }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                string oldValue = _name;
                _name = value;
                Debug.WriteLine($"User.Name changed: '{oldValue}' -> '{_name}'");
            }
        }

        private string _description = string.Empty;
        public string Description
        {
            get => _description;
            set
            {
                string oldValue = _description;
                _description = value;
                Debug.WriteLine($"User.Description changed: '{oldValue}' -> '{_description}'");
            }
        }

        public User Clone()
        {
            return new User
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }
    }
}