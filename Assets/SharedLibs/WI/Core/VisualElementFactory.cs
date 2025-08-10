using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.SharedLibs.WI
{
    public interface IVisualElementFactory
    {
        VisualTreeAsset Asset { get; }
        VisualElement GetOrCreate();
        void Store(VisualElement element);
    }

    public class VisualElementFactory : IVisualElementFactory
    {
        private string AssetLocation { get; }
        private List<VisualElement> Heap { get; } = new List<VisualElement>();
        public VisualElementFactory(string assetLocation)
        { 
            AssetLocation = assetLocation;  
        }

        private VisualTreeAsset _asset; 
        public VisualTreeAsset Asset => _asset = _asset ?? Resources.Load<VisualTreeAsset>(AssetLocation);

        public VisualElement GetOrCreate()
        {
            if (Heap.Any())
            { 
                VisualElement result = Heap.First();
                Heap.Remove(result);
                return result;  
            }
            return Asset.Instantiate().Q<VisualElement>();
        }

        public void Store(VisualElement element)
        {
            Heap.Add(element);
        }
    }
}