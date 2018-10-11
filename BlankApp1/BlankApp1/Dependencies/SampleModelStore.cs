using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.Dependencies
{
    public class SampleModelStore : SampleBaseStore<SampleModel>, ISampleModelStore
    {
        public SampleModelStore(ISampleClient client) : base(client)
        {
        }
    }

    public interface ISampleModelStore : ISampleBaseStore<SampleModel> {

    }
}
