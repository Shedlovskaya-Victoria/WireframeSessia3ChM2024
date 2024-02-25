using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WireframeSessia3ChM2024
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public List<Sample> Samples { get; set; }
        public Page1()
        {
            InitializeComponent(); 
            DataContext = this;
            Samples = new List<Sample>()
            {
                new Sample(){Code = "1234", Id = 1, Date = "01.03.2024", Bal = 2},
                new Sample(){Code = "1234", Id = 2, Date = "03.03.2024", Bal = 3},
                new Sample(){Code = "1234", Id = 3, Date = "06.03.2024", Bal = 2},
                new Sample(){Code = "1234", Id = 4, Date = "12.03.2024", Bal = 5},
            };
        }
    }
}
