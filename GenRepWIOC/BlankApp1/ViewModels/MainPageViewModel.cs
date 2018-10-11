using BlankApp1.Dependencies;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ISampleModelStore store;
        private IAnotherStore another;

        public MainPageViewModel(
            INavigationService navigationService,
            ISampleModelStore store,
            IAnotherStore another)
            : base(navigationService)
        {
            Title = "Main Page";
            this.store = store;
            this.another = another;
            GetNames();
        }

        private void GetNames()
        {
            store.Client.ClientName = "Client Alex";
            var a = another.Client.ClientName;
        }
    }
}
