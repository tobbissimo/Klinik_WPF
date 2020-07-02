using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikApp.ViewModel
{
    class VMPatientEdit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IstInEditMode { get; set; }

        public Patient P { get; set; }

        public int NrOfExams 
        { 
            get
            {
                return P.Examinations.Count();
            }
        }

        public String HeaderText
        {
            get
            {
                if (IstInEditMode)
                {
                    return "Edit Patient";
                }
                return "New Patient";
            }
        }

        public IEnumerable<Bundesland> AllBundeslands
        {
            get
            {
                using (KlinikDbEntities db = new KlinikDbEntities())
                {
                    var erg = from b in db.Bundeslands
                              select b;
                    return erg.ToList();
                }
            }
        }

        public String NrOfOps()
        {
            return P.Examinations.Count().ToString();
        }

    }
}
