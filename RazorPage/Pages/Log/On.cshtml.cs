using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;

namespace RazorPage
{
    [BindProperties]
    public class OnModel : PageModel
    {
        public LogOnUser LogOnOne { get; set; }
        public bool RememberMe { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "登录-一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new UserLogOn().Sava(LogOnOne);
        }
    }
    public class LogOnUser
    {
        public int Id { get; set; }

        [Display(Name = "用户名：（* 必填）")]
        [Required(ErrorMessage = "* 用户名不能为空")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "* 用户名长度不能小于{2}也不能大于{1}")]
        public string LogOnUserName { get; set; }

        [Display(Name = "密码：（* 必填）")]
        [Required(ErrorMessage = "* 密码不能为空")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "* 密码必须在{2} 和{1}之间")]
        public string LogOnUserPassword { get; set; }

        [Display(Name = "验证码:")]
        [Required(ErrorMessage = "* 验证码不能为空")]
        [MaxLength(4, ErrorMessage = "* 验证码长度最大4位")]
        public string LogOnUserVerification { get; set; }
    }
}