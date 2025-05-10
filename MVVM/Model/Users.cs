using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblyChat.MVVM.Model
{
    public class Users
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }

        public bool FirstLogin { get; set; }

        public string Avatar { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
