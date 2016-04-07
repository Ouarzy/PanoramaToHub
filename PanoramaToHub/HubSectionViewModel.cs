namespace PanoramaToHub
{
    public class HubSectionViewModel
    {
        public HubSectionViewModel(string sectionHeader, string sectionNumber)
        {
            SectionHeader = sectionHeader;
            SectionNumber = sectionNumber;
        }

        public string SectionHeader { get; private set; }
        public string SectionNumber { get; private set; }
    }
}