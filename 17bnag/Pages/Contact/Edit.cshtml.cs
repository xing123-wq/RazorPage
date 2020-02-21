using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _17bnag.Layout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bnag.Contact
{
    [BindProperties]
    public class EditModel : _LayoutModel
    {
        public ContactEdit EditOne { get; set; }
        public void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "修改联系方式-一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new UserEdit().Sava(EditOne);
        }
    }
    public class UserEdit
    {
        public void Sava(ContactEdit user)
        {

        }
    }
    public class ContactEdit
    {
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

        [Display(Name = "Email:(*必填)")]
        [Required(ErrorMessage = "* Email不能为空")]
        [EmailAddress(ErrorMessage = "* 电子邮件格式不正确")]
        public string UserEmail { get; set; }
    }
}