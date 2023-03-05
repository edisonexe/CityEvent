using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using CityEvents.Models;
using DynamicData;
using ReactiveUI;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems1;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems2;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems3;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems4;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems5;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems6;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems7;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems8;
        private readonly ReadOnlyObservableCollection<CityEvent> _cItems9;

        public MainWindowViewModel()
        {
            CityEvent[] events = Serializer<CityEvent[]>.Load("../../../events.xml");

            SourceList<CityEvent> sourceList = new();

            foreach (var e in events)
            {
                sourceList.Add(e);
            }

            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Kid)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems1).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Sport)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems2).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Culture)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems3).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Excursions)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems4).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Lifestyle)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems5).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Party)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems6).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Education)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems7).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Online)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems8).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category)
                .Filter(x => x.Category.Show)
                .ObserveOn(RxApp.MainThreadScheduler).Bind(out _cItems9).Subscribe();
        }

        public ReadOnlyObservableCollection<CityEvent> CItems1 => _cItems1;
        public ReadOnlyObservableCollection<CityEvent> CItems2 => _cItems2;
        public ReadOnlyObservableCollection<CityEvent> CItems3 => _cItems3;
        public ReadOnlyObservableCollection<CityEvent> CItems4 => _cItems4;
        public ReadOnlyObservableCollection<CityEvent> CItems5 => _cItems5;
        public ReadOnlyObservableCollection<CityEvent> CItems6 => _cItems6;
        public ReadOnlyObservableCollection<CityEvent> CItems7 => _cItems7;
        public ReadOnlyObservableCollection<CityEvent> CItems8 => _cItems8;
        public ReadOnlyObservableCollection<CityEvent> CItems9 => _cItems9;
    }
}