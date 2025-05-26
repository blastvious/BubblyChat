using Firebase.Database;
using BubblyChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace BubblyChat.Service
{
    
    public class FirebaseRTDB
    {
        private readonly FirebaseClient _firebaseClient;
        private const string DatabaseUrl = "https://bubblychatapp-default-rtdb.firebaseio.com/";
        public FirebaseRTDB()
        {
            _firebaseClient = new FirebaseClient(DatabaseUrl);
        }

        //Luu du lieu
        public async Task SaveUserAsync(Users user)
        {
            await _firebaseClient
                .Child("users")
                .Child(user.Id)
                .PutAsync(user);
        }

        public async Task UpdateUserAsync(Users user)
        {
            await _firebaseClient
                .Child("users")
                .Child(user.Id)
                .PutAsync(user);
        }
        //Lay du lieu
        public async Task<Users> GetUserAsync(string userId)
        {
            var user = await _firebaseClient
                .Child("users")
                .Child(userId)
                .OnceSingleAsync<Users>();
            return user;
        }

    }
}
