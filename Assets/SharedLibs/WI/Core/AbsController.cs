using System.Data.Common;

namespace AlSo.WI
{
    public interface IController
    {
        void Enable();
        void Disable();
        public void Hide();
        public void Show();
    }

    public interface IController<T> where T : IModel
    { 
        T Data { get; set; }
    }


    public abstract class AbsController : IController
    {
        protected IView AbsView { get; }

        public AbsController(IView view)
        {
            AbsView = view; 
        }
        
        public abstract void Enable();
        public void Disable() { }
        public void Hide() { }// => AbsView.GameObject.SetActive(false);
        public void Show() { }// => AbsView.GameObject.SetActive(true);
    }

    public abstract class AbsController<T> : AbsController, IController<T> where T : IModel
    {
        protected AbsController(IView view) : base(view) { }

        private bool _isEnabled;
        private T _data;

        public T Data 
        { 
            get => _data;
            set
            {
                if (!_isEnabled) Enable();

                if (_data!=null && _data.Equals(value))
                {
                    Rerender();
                    return;
                }
                else
                {
                    _data = value;
                    RenderNew();
                }
            }
        }

        public sealed override void Enable()
        {
            AddListeners();
            _isEnabled = true;  
        }

        protected abstract void AddListeners();
        protected abstract void Rerender();
        protected abstract void RenderNew();
    }

    public abstract class AbsSimpleController<T> : AbsController<T> where T : IModel
    {
        public AbsSimpleController(IView view) : base(view) { }

        protected abstract void Render();

        protected override void RenderNew() => Render();

        protected override void Rerender() => Render();
    }
}
