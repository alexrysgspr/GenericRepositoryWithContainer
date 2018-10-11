using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.Dependencies
{
    public class SampleBaseStore<T> : ISampleBaseStore<T> where T : class, IBaseModel , new()
    {
        public T t { get; set; }
        public ISampleClient Client { get; set; }
        public SampleBaseStore(ISampleClient client) => Client = client;

        public string GetId() => t.Id;
    }

    public interface ISampleBaseStore<T>
    {
        ISampleClient Client { get; set; }
        string GetId();
    }
}
