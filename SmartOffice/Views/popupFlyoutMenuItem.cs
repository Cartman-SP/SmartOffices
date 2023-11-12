using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOffice.Views
{
    public class popupFlyoutMenuItem
    {
        public popupFlyoutMenuItem()
        {
            TargetType = typeof(popupFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}