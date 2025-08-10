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
    public interface IArticleSetModel : IModel
    {
        string Title { get; }
        IEnumerable<IArticleModel> Articles { get; }
    }

    public class ArticleSetModel : IArticleSetModel
    {
        public string Title => "Lorem Ipsum Set";

        public IEnumerable<IArticleModel> Articles { get; } = new IArticleModel[] { new ArticleModel(), new ArticleModel(), new ArticleModel(), new ArticleModel(), };
    }
}