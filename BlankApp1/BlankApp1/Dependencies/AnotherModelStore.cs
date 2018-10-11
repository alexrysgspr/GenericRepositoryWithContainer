using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.Dependencies
{
    public class AnotherStore : SampleBaseStore<AnotherModel>, IAnotherStore
    {
        public AnotherStore(ISampleClient client) : base(client)
        {
        }
    }

    public interface IAnotherStore : ISampleBaseStore<AnotherModel>
    {

    }
}
