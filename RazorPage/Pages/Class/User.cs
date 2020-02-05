using System.ComponentModel.DataAnnotations;

namespace RazorPage
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*确认密码不能为空")]
        public string ValidatePassword { get; set; }
        [Required(ErrorMessage = "*邀请人不能为空")]
        public string inviter { get; set; }
        [Required(ErrorMessage = "*邀请码不能为空")]
        public int Invitationcode { get; set; }
    }
}