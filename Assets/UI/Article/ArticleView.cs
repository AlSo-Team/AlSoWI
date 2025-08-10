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
    public interface IArticleView : IView
    {
        Label Title { get; }
        Label Description { get; }
        VisualElement Image { get; }
    }

    public class ArticleView : AbsView, IArticleView
    {
        public Label Title => Root.Q<Label>("Title");
        public Label Description => Root.Q<Label>("Description");
        public VisualElement Image => Root.Q<VisualElement>("Image");
        public VisualElement Body => throw new Exception();// Root.Q<VisualElement>("Body");
        protected override string VisualTreeAssetLocation => "UI/Article";
        public override VisualElement DefaultSocketReturner => Body;
        public VisualElement BodyReturner() => throw new Exception();
    }
}