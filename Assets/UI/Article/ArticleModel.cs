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
    public interface IArticleModel : IModel
    { 
        string Title { get; }
        string Description { get; }
        Texture2D Texture { get; }
    }

    public class ArticleModel : IArticleModel
    {
        public string Title { get; }

        public string Description { get; }

        public Texture2D Texture { get; }

        public ArticleModel()
        {
            Title = "Lorem Ipsum";
            Description = @"We then loop through all of the child VisualElement objects of the TemplateContainer using a foreach loop and the Children() method of the VisualElement class.

Inside the loop, we check if the current child is a TemplateContainer by using the is keyword. If the current child is not a TemplateContainer, we assign it to the firstChild variable and break out of the loop. We then loop through all of the child VisualElement objects of the TemplateContainer using a foreach loop and the Children() method of the VisualElement class.

Inside the loop, we check if the current child is a TemplateContainer by using the is keyword. If the current child is not a TemplateContainer, we assign it to the firstChild variable and break out of the loop."
            ;

            Texture = Resources.Load<Sprite>("Images/face100").texture;
        }
    }


}