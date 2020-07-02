using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KlinikApp.ViewModel
{
    class VMExamEdit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IstInEditMode { get; set; }

        public Examination Ex { get; set; }

        public String HeaderText
            {
            get 
            {
                if(IstInEditMode)
                {
                    return "Edit Examination";
                }
                return "New Examination"; 
            }
        }

        public IEnumerable<Klinik> AllKliniks
        {
            get
            {
                using (KlinikDbEntities db = new KlinikDbEntities())
                {
                    var erg = from k in db.Kliniks.Include("Employees")
                              select k;
                    return erg.ToList();
                }
            }

        }

        public IEnumerable<Employee> AllEmployees
        {
            get
            {
                using (KlinikDbEntities db = new KlinikDbEntities())
                {
                    return db.Employees.ToList();
                }
            }
        }
        public IEnumerable<Examtype> AllExams
        {
            get
            {
                using (KlinikDbEntities db = new KlinikDbEntities())
                {
                    return db.Examtypes.ToList();
                }
            }
        }

        
    }
}
