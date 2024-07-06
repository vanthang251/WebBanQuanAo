using VanThang251_Sales.UseCase.PluginInterface.StateStore;

namespace VanThang251_Sales.StateStore.DI
{
    public class StateStoreBase : IStateStore
    {
        protected Action _listeners;
        public void AddStateChangeListeners(Action listeners)=>this._listeners += listeners;
       
        public void RemoveSateChangeListeners(Action listeners) => this._listeners -= listeners;

        public void BroadCastStateChange()
        {
            //throw new NotImplementedException();
            if (this._listeners != null)
                this._listeners.Invoke();
        }
    }
}
