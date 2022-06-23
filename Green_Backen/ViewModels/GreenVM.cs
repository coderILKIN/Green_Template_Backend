using Green_Backen.Models;
using System.Collections.Generic;

namespace Green_Backen.ViewModels
{
    public class GreenVM
    {
        public List<Slider> Sliders { get; set; }

        public List<MainIcon> MainIcons { get; set; }

        public About About { get; set; }

        public List<Service> Services { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
