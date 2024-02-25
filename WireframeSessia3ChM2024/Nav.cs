using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WireframeSessia3ChM2024
{
    public class Nav : INotifyPropertyChanged
    {
        static Nav nav;
        private Page current;

        public Page PAge { 
            get => current;
            set
            {
                current = value;
                Signal();
            }
        }

        public void Signal([CallerMemberName] string prop = null) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler? PropertyChanged;

        public static Nav Inst()
        {
            if(nav == null)
                nav = new Nav();

            return nav;
        }
    }
}
