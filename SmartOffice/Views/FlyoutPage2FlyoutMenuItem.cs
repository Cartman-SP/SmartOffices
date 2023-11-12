using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOffice.Views
{

    public class FlyoutPage2FlyoutMenuItem
    {
        public FlyoutPage2FlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPage2FlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}