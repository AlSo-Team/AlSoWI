using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace AlSo.WI
{


    public abstract class AbsVisualTreeAssetOwner : IVisualTreeAssetOwner
    {
        private VisualTreeAsset _visualTreeAsset;
        public VisualTreeAsset VisualTreeAsset => _visualTreeAsset = _visualTreeAsset ?? Resources.Load<VisualTreeAsset>(VisualTreeAssetLocation);
        protected abstract string VisualTreeAssetLocation { get; }

        public abstract VisualElement Root { get; }       
        public abstract TemplateContainer TemplateContainer { get;  }
        public abstract AbsScreen StyleCollector { get; }
        public void AddChild(IView child, Func<VisualElement> socketReturner = null)
        {
            VisualElement parent = socketReturner!=null ? socketReturner.Invoke() : DefaultSocketReturner;

            parent.Add(child.Root);

            for (int i = 0; i < child.TemplateContainer.styleSheets.count; i++)
            {
                StyleSheet styleSheet = child.TemplateContainer.styleSheets[i];
                if (StyleCollector.TemplateContainer.styleSheets.Contains(styleSheet)) continue;
                StyleCollector.TemplateContainer.styleSheets.Add(styleSheet);
            }

            child.DefineStyleCollector(StyleCollector);
        }

        public abstract VisualElement DefaultSocketReturner { get; }
    }
}