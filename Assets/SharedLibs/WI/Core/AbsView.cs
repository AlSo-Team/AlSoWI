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
    public interface IView : IVisualTreeAssetOwner
    {
        void DefineStyleCollector(AbsScreen styleCollector);
    }

    public abstract class AbsView : AbsVisualTreeAssetOwner, IView
    {
        protected VisualElement _root;
        public override VisualElement Root => _root = _root ?? GetRoot();
        private VisualElement GetRoot() => TemplateContainer.ElementAt(0);

        protected AbsScreen _styleCollector;
        public override AbsScreen StyleCollector => _styleCollector;
        public void DefineStyleCollector(AbsScreen styleCollector)
        {
            _styleCollector = styleCollector;
        }

        protected TemplateContainer _templateContainer;
        public override TemplateContainer TemplateContainer => _templateContainer = _templateContainer ?? VisualTreeAsset.Instantiate();

        public override VisualElement DefaultSocketReturner => Root;
    }

 
}