using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RazorPage
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* 用户名不能为空")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "* 用户名长度不能小于{2}也不能大于{1}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "* 密码必须在{2} 和{1}之间")]
        public string Password { get; set; }
        [Required(ErrorMessage = "* 确认密码不能为空")]
        [Compare("Password", ErrorMessage = "* 确认密码和密码不一致")]
        public string ValidatePassword { get; set; }
        [Required(ErrorMessage = "* 邀请人不能为空")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "* 邀请人长度不能小于{2}也不能大于{1}")]
        public string inviter { get; set; }
        [Required(ErrorMessage = "* 邀请码不能为空")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "* 邀请码只能是4位数")]
        public int Invitationcode { get; set; }
    }
}