using System.Collections;
using System.Collections.Generic;

namespace PanoramaToHub
{
    public class MainViewModel
    {
        public IEnumerable<HubSectionViewModel> HubSections { get; private set; }

        public MainViewModel()
        {
            HubSections = new List<HubSectionViewModel>
            {
                new HubSectionViewModel("1", "Content1"),
                new HubSectionViewModel("2", "Content2"),
                new HubSectionViewModel("3", "Content3"),
                new HubSectionViewModel("4", "Content4"),
                new HubSectionViewModel("5", "Content5")
            };
        }
    }
}
