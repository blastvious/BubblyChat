using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using BubblyChat.MVVM.Model;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
namespace BubblyChat.Service
{
    public class FirebaseAuthService
    {
        private const string ApiKey = "AIzaSyCQoWUMYseTNtBdMyP0enMs4nrQrMRQ9LE";
        private const string AuthDomain = "bubblychatapp.firebaseapp.com";
        private readonly FirebaseAuthClient _authClient;
        

        private UserCredential _userCredential;
        public string _messageError;

        public FirebaseAuthService()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider() 
                },
               
                UserRepository = new FileUserRepository("BubblyChat") 
            };
            _authClient = new FirebaseAuthClient(config);

        }

        public async Task<Users> RegisterUserAsync(string email, string password)
        {
            try
            {
                _userCredential = await _authClient.CreateUserWithEmailAndPasswordAsync(email, password);
                var user = _userCredential.User;
                return new Users
                {
                    Id = user.Uid,
                    Email = email,
                    CreatedAt = DateTime.Now

                };
            }
            catch (FirebaseAuthException ex)
            {
                _messageError = GetFriendlyErrorMessage(ex);
                string message = GetFriendlyErrorMessage(ex);
                Console.WriteLine("Lỗi đăng ký: " + message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi không xác định: " + ex.Message);
                return null;
            }
        }

        public async Task<Users> LoginUserAsync(string email, string password)
        {
            try
            {
                _userCredential = await _authClient.SignInWithEmailAndPasswordAsync(email, password);
                var user = _userCredential.User;
                return new Users
                {
                    Id = user.Uid,
                    Email = user.Info.Email,
                    CreatedAt = DateTime.Now
                };
            }
            catch (FirebaseAuthException ex)
            {
                _messageError = GetFriendlyErrorMessage(ex);
                Console.WriteLine("Lỗi đăng nhập: " + _messageError);
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Lỗi không xác định: " + ex.Message);
                return null;
            }
        }

        public static string SecureStringToString(SecureString secureString)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }


        public async Task<bool> SendPasswordResetEmailAsync(string email)
        {
            try
            {
                await _authClient.ResetEmailPasswordAsync(email);
                _messageError = "Đã gửi email đặt lại mật khẩu đến " + email;
                return true;
            }
            catch (FirebaseAuthException ex)
            {
                _messageError = GetFriendlyErrorMessage(ex);
                return false;
            }
            catch (Exception ex)
            {
                _messageError = "Lỗi không xác định: " + ex.Message;
                return false;
            }
        }
      

      

        private string GetFriendlyErrorMessage(FirebaseAuthException ex)
        {
            switch (ex.Reason)
            {
                case AuthErrorReason.EmailExists:
                    return "Email này đã được đăng ký";
                case AuthErrorReason.WeakPassword:
                    return "Mật khẩu phải có ít nhất 6 ký tự";
                case AuthErrorReason.WrongPassword:
                    return "Sai mật khẩu";  
                case AuthErrorReason.InvalidEmailAddress:
                    return "Email không hợp lệ";
                case AuthErrorReason.UserNotFound:
                    return "Người dùng không tồn tại";
                default:
                    return $"Lỗi: {ex.Reason}";
            }
        }

    }
}
