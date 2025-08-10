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
    public interface IScreen : IVisualTreeAssetOwner
    {
        PanelSettings PanelSettings { get; }
        GameObject GameObject { get; }
    }

    public interface IVisualTreeAssetOwner
    {
        VisualTreeAsset VisualTreeAsset { get; }
        TemplateContainer TemplateContainer { get; }
        VisualElement Root { get; }
        void AddChild(IView child, Func<VisualElement> socketReturner = null);
        VisualElement DefaultSocketReturner { get; }
        AbsScreen StyleCollector { get; }
    }

    public abstract class AbsScreen : AbsVisualTreeAssetOwner, IScreen
    {
        public GameObject GameObject { get; }
        protected UIDocument UIDocument { get; }

        public AbsScreen()
        {
            GameObject = new GameObject("Screen");
            UIDocument = GameObject.AddComponent<UIDocument>();

            UIDocument.panelSettings = PanelSettings;
            UIDocument.visualTreeAsset = VisualTreeAsset;
        }

        private static PanelSettings _defultPanelSettings;
        public static PanelSettings DefaultPanelSettings => _defultPanelSettings = _defultPanelSettings ?? Resources.Load<PanelSettings>("Settings/Panel Settings");
        public virtual PanelSettings PanelSettings => DefaultPanelSettings;

        //protected TemplateContainer _templateContainer;
        public override TemplateContainer TemplateContainer => UIDocument.rootVisualElement as TemplateContainer;

        public override AbsScreen StyleCollector => this;
        public sealed override VisualElement DefaultSocketReturner => Root;

        public override VisualElement Root => UIDocument.rootVisualElement.Q<VisualElement>("Root");
    }

    public class CommonScreen : AbsScreen//, IMainMenuView
    {
        public CommonScreen() : base() { }

        //public Button First => UIDocument.rootVisualElement.Q<Button>("First");
        //public Button Second => UIDocument.rootVisualElement.Q<Button>("Second");
        //public Button Third => UIDocument.rootVisualElement.Q<Button>("Third");

        //public Button Item => UIDocument.rootVisualElement.Q<Button>("Item");

        //public ScrollView BoxA => UIDocument.rootVisualElement.Q<ScrollView>("BoxA");
        //public ScrollView BoxB => UIDocument.rootVisualElement.Q<ScrollView>("BoxB");

        //public VisualElement VisualElement => UIDocument.rootVisualElement.Q<VisualElement>("Box");

        protected override string VisualTreeAssetLocation => "UI/Screen";


    }
}