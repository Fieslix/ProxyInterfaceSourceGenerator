﻿namespace ProxyInterfaceConsumer
{
    [ProxyInterfaceGenerator.Proxy(typeof(ProxyInterfaceConsumer.PersonT<,>))]
    public partial interface IPersonT<T1, T2>
        where T1 : struct
        where T2 : class, new()
    {
    }

    [ProxyInterfaceGenerator.Proxy(typeof(ProxyInterfaceConsumer.PersonTT<,>))]
    public partial interface IPersonTT<T1, T2> 
        where T1 : struct
        where T2 : class, new()
    {
    }
}