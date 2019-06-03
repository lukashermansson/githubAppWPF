using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubWPF.Models
{
    public class Repository : INotifyPropertyChanged
    {
        private String _Name;

        public String Name {
            get { return _Name; }
            set { _Name = value;
                OnPropertyRaised("Name");
            }
        }

        private String _Description;

        public String Description {
            get { return _Description; }
            set { _Description = value;
                OnPropertyRaised("Description");
            }
        }

        private String _Language;

        public String Language {
            get { return _Language; }
            set { _Language = value;
                OnPropertyRaised("Langauge");
            }
        }

        private DateTime _Updated_At;

        public DateTime Updated_At {
            get { return _Updated_At; }
            set { _Updated_At = value;
                OnPropertyRaised("Updated_At");
            }
        }
            

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
