using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RazorPage
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "用户名：（* 必填）")]
        [Required(ErrorMessage = "* 用户名不能为空")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "* 用户名长度不能小于{2}也不能大于{1}")]
        public string Name { get; set; }

        [Display(Name = "密码：（* 必填）")]
        [Required(ErrorMessage = "*密码不能为空")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "* 密码必须在{2} 和{1}之间")]
        public string Password { get; set; }

        [Display(Name = "验证密码：（* 必填）")]
        [Required(ErrorMessage = "* 确认密码不能为空")]
        [Compare("Password", ErrorMessage = "* 确认密码和密码不一致")]
        public string ValidatePassword { get; set; }

        [Display(Name = "邀请人：")]
        [Required(ErrorMessage = "* 邀请人不能为空")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "* 邀请人长度不能小于{2}也不能大于{1}")]
        public string inviter { get; set; }

        [Display(Name = "邀请码：（* 必填）")]
        [RegularExpression("[0-9]*", ErrorMessage = "* 邀请码只能是4位数字")]
        [Required(ErrorMessage = "* 邀请码不能为空")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "* 邀请码只能是4位数")]
        public int Invitationcode { get; set; }

        [Display(Name = "QQ:")]
        [Required(ErrorMessage = "* QQ号码不能为空")]
        [RegularExpression("[0-9]*", ErrorMessage = "* QQ号码格式错误")]
        [StringLength(11, MinimumLength = 6, ErrorMessage = "* QQ号码不能大于{1}也不能小于{2}")]
        public int TencentNumber { get; set; }

        [Display(Name = "微信:")]
        [Required(ErrorMessage = "* 微信号码不能为空")]
        [StringLength(11, MinimumLength = 4, ErrorMessage = "* 微信号码不能大于{1}也不能小于{2}")]
        public string WechatNumber { get; set; }

        [Display(Name = "电话:")]
        [Required(ErrorMessage = "* 电话不能为空")]
        [RegularExpression("[0-9]*", ErrorMessage = "* 电话号码格式错误")]
        [MinLength(11, ErrorMessage = "* 电话号码只能是11位")]
        public int PhoneNumber { get; set; }
    }
}