//using AlSo.WI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine;
//using UnityEngine.UIElements;

//namespace Assets.UI.custom
//{
//    public interface ISettingsView : IView
//    {
//        Button First { get; }
//        Button Second { get; }
//        Button Third { get; }
//    }

//    public class SettingsCtrl : AbsViewController
//    {
//        public Action OnFirstHandler { get; set; }
//        public Action OnSecondHandler { get; set; }
//        public Action OnThirdHandler { get; set; }

//        protected ISettingsView Target { get; }

//        public SettingsCtrl(ISettingsView target):base(target) 
//        {
//            Target = target;
//        }

//        public override void Enable()
//        { 
//            Target.First.clickable.clicked += OnFirst;
//            Target.Second.clickable.clicked += OnSecond;
//            Target.Third.clickable.clicked += OnThird;
//        }

//        private void OnFirst()=> OnFirstHandler?.Invoke();
//        private void OnSecond() => OnSecondHandler?.Invoke();
//        private void OnThird() => OnThirdHandler?.Invoke();

//        public override void Disable()
//        {
//        }

//    }
//}
