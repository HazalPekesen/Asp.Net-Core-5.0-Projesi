using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMVC.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Hazal"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Efe"
                },
                new UserComment
                {
                    Id=3,
                    UserName="Güçlüer"
                }
            };
            return View(commentValues);
        }
    }
}
