//
// Copyright (c) ZeroC, Inc. All rights reserved.
//

public class HelloPluginFactoryI : Ice.PluginFactory
{
    public Ice.Plugin create(Ice.Communicator communicator, string name, string[] args)
    {
        return new HelloPluginI(communicator);
    }
}
