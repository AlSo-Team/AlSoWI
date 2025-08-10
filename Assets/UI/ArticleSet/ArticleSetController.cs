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
    public interface IArticleSetController : IController<IArticleSetModel> { }

    public class ArticleSetController : AbsSimpleController<IArticleSetModel>, IArticleSetController
    {
        protected IPanelView View { get; }


        public ArticleSetController(IPanelView view) : base(view)
        {
            this.View = view;
        }

        protected override void Render()
        {
            View.Title.text = Data.Title;
            
            foreach (IArticleModel article in Data.Articles) 
            {
                IArticleView view = new ArticleView();
                IArticleController controller = new ArticleController(view);
                View.AddChild(view);
                controller.Data = article;
            }
        }

        protected override void AddListeners()
        {
        }
    }
}
