using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace AlSo.WI
{
    public interface IArticleController : IController<IArticleModel> { }

    public class ArticleController : AbsSimpleController<IArticleModel>, IArticleController
    {
        protected IArticleView View { get; }
        

        public ArticleController(IArticleView view) : base(view)
        { 
            this.View = view;   
        }

        protected override void Render()
        {
            View.Title.text = Data.Title;
            View.Description.text = Data.Description;
            View.Image.style.backgroundImage = Data.Texture;
        }

        protected override void AddListeners()
        {
        }
    }
}
