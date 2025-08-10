using AlSo.WI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace AlSo.WI
{
    public interface IPanelView : IView
    { 
        Label Title { get; }
        VisualElement Body { get; }
    }

    public class PanelView : AbsView, IPanelView
    {
        public Label Title => Root.Q<Label>("Title");
        public virtual VisualElement Body => Root.Q<VisualElement>("Body");
        protected override string VisualTreeAssetLocation => "UI/Panel";
        public override VisualElement DefaultSocketReturner => Body;
        public VisualElement BodyReturner() => Body;
    }

    public class PanelScrollableView : PanelView, IPanelView
    {
        protected override string VisualTreeAssetLocation => "UI/PanelScrollable";
        public override VisualElement Body => Root.Q<VisualElement>("unity-content-container");
    }
}