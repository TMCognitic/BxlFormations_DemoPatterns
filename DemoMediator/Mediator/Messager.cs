using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMediator.Mediator
{
    public class Messager<TSender, TMessage>
    {
        #region Singleton Pattern
        private static Messager<TSender, TMessage> _instance;

        public static Messager<TSender, TMessage> Instance
        {
            get
            {
                return _instance ?? (_instance = new Messager<TSender, TMessage>());
            }
        }

        private Messager()
        {

        }
        #endregion

        private Action<TSender, TMessage> _broadcast;       

        public void Register(Action<TSender, TMessage> action)
        {
            _broadcast += action;
        }

        public void Unregister(Action<TSender, TMessage> action)
        {
            _broadcast -= action;
        }

        public void Send(TSender sender, TMessage message)
        {
            _broadcast?.Invoke(sender, message);
        }
    }
}
