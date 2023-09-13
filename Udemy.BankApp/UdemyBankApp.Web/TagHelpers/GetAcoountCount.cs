using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using UdemyBankApp.Web.Data.Context;

namespace UdemyBankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAcoountCount")]
    public class GetAcoountCount : TagHelper
    {
        public int ApplicationUserId { get; set; }
        private readonly BankContext _context;

        public GetAcoountCount(BankContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x => x.ApplicationUserId == ApplicationUserId);
            var html = $"<span class='badge bg-danger'> {accountCount} </span>";
            output.Content.SetHtmlContent(html);
        }
    }

}





