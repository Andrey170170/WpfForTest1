using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfForTest
{
    public class Services
    {
        public Services (string coverImage, string title)
        {
            CoverImage = coverImage;
            Title = title;
        }

        public string CoverImage { get; set; }
        public string Title { get; set; }
    }
}
