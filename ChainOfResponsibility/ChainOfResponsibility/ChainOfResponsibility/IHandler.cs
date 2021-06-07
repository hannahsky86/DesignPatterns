using System.Collections.Generic;

namespace ChainOfResponsibility
{

    public interface IHandler
    {
        IHandler SetNext(IHandler h);

        object Handle(object request);
    }

}