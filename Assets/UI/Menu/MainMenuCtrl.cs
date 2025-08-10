//using AlSo.WI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;
//using UnityEngine.UIElements;

//namespace Assets.UI.custom
//{
//    public interface IMainMenuView : IView
//    {
//        Button First { get; }
//        Button Second { get; }
//        Button Third { get; }

//        Button Item { get; }
//        ScrollView BoxA { get; }
//        ScrollView BoxB { get; }

//        VisualElement VisualElement { get; }
//    }

//    public class MainMenuCtrl : AbsViewController
//    {
//        //public Action OnFirstHandler { get; set; }
//        //public Action OnSecondHandler { get; set; }
//        public Action OnThirdHandler { get; set; }

//        public IMainMenuView Target { get; }

//        public MainMenuCtrl(IMainMenuView target) : base(target)
//        {
//            Target = target;
//        }

//        public override void Enable()
//        { 
//            Target.First.clickable.clicked += OnFirst;
//            Target.Second.clickable.clicked += OnSecond;
//            Target.Third.clickable.clicked += OnThird;
//        }

//        private void OnFirst()
//        {
//            Target.BoxB.Add(Target.Item);
        
//        }
//        private void OnSecond()
//        {
//            Target.BoxA.Add(Target.Item);
//        }
        
//        private void OnThird() => OnThirdHandler?.Invoke();

//        public override void Disable()
//        {
//        }
//    }
//}
