using System.Collections.Generic;

namespace ChainOfResponsibility
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler h)
        {
            this._nextHandler = h;
            return h;
        }
    }
}