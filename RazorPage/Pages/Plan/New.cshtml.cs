using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    [BindProperties]
    public class NewModel : PageModel
    {
        public PublishUser PlanNewOn { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "发布新目标--一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new PublishRepoistoy().Sava(PlanNewOn);
        }
    }
    public class PublishRepoistoy
    {
        public void Sava(PublishUser publishUser)
        {

        }
    }
    public class PublishUser
    {
        [Display(Name = "标题(必填):")]
        [Required(ErrorMessage = "* 标题不能为空")]
        [StringLength(25, ErrorMessage = "* 标题长度不能大于25")]
        public string Title { get; set; }

        [Display(Name = "标签(* 必填):")]
        [Required(ErrorMessage = "* 关键字不能为空")]
        [StringLength(25, ErrorMessage = "* 标签长度不能大于25")]
        public string KeywordLabel { get; set; }

        [Display(Name = "未交作业罚金（必填）：")]
        [Required(ErrorMessage = "* 未交作业惩罚不能为空")]
        [RegularExpression("[0-9]*", ErrorMessage = "* 只能输入正整数")]
        //[MinLength(1, ErrorMessage = "* 长度不能小于1")]
        public int PunishCount { get; set; }
    }
}