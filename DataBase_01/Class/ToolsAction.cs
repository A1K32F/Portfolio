using DataBase_01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataBase_01.Interface_;

namespace DataBase_01.Tools
{
    class ToolsAction : IEszköz,IMegrendelo
    {


        //Keszulek
        private DateTime Dateid;
        public DateTime dateid
        {
            get
            {
                return Dateid;
            }
            set
            {
                if (value !=null)
                {
                    Dateid = value;
                }
                else
                {
                    throw new Exception("Hibás id!");
                }
            }
           
        }
       
        private string Marka;
        public string marka
        {
            get
            {
                return Marka;
            }
            set
            {
                if(value != null)
                {
                    Marka = value;
                }
                else
                {
                    throw new Exception("Hibás Márka információ!");
                }
            }
           
        }
        private string Tipus;
        public string tipus
        {
            get
            {
                return Tipus;
            }
            set
            {
                if(value != null)
                {
                    Tipus = value;
                }
                else
                {
                    throw new Exception("Hibás Típus információ!");
                }
            }
        }
        private string Tartozek;
        public string tartozek
        {
            get
            {
                return Tartozek;
            }
            set
            {
                if(value != null)
                {
                    Tartozek = value;
                }
                else
                {
                    throw new Exception("Hibás tartozék érték!");
                }

            }
           
        }
        private bool Hordozhato;
        public bool hordozhato
        {
            get
            {
                return Hordozhato;
            }
            set
            {
                if(value)
                {
                    Hordozhato = true;
                }
                else
                {
                    Hordozhato = false;
                }
            }
           
        }
        private bool RepairNew;
        public bool repairNew
        {
            get
            {
                return RepairNew;
            }
            set
            {
                if (value)
                {
                    RepairNew = true;
                }
                else
                {
                    RepairNew = false;
                }
            }
            
        }
        private string Megjegyzes;
        public string megjegyzes
        {
            get
            {
                return Megjegyzes;
            }
            set
            {
                if (value != null)
                {
                    Megjegyzes = value;
                }
                else
                {
                    throw new Exception("Hibás Megjegyzés!");
                }
            }
           
        }
        //Tulajdonos
        private string Fname;
        public string fname
        {
            get
            {
                return Fname;
            }
            set
            {
                if (value!= null)
                {
                    Fname = value;
                }
                else
                {
                    throw new Exception("Hibás Keresztnév");
                }
            }
           
        }
        private string Lname;
        public string lname
        {
            get
            {
                return Lname;
            }
            set
            {
                if (value!= null)
                {
                    Lname = value;
                }
                else
                {
                    throw new Exception("Hibás vezetéknév!");
                }
            }
           
        }
        private string PhoneN;
        public string phoneN
        {
            get
            {
                return PhoneN;
            }
            set
            {
                if(value !=null)
                {
                    PhoneN = value;
                }
                else
                {
                    throw new Exception("Hibás telefonszám!");
                }
            }
           
        }
        private string Email;
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                if (value != null )
                {
                    Email = value;
                }
                else
                {
                    throw new Exception("Hibás Email!");
                }
            }
           
        }
        public ToolsAction(string marka, string tipus, string tartozek, bool hordozhato, bool repairNew, 
            string megjegyzes, string fName, string lName, string pHoneN, string email) 
        {
            this.dateid = DateTime.Now;
            this.marka = marka;
            this.tipus = tipus;
            this.tartozek = tartozek;
            this.hordozhato = hordozhato;
            this.repairNew= repairNew;
            this.megjegyzes = megjegyzes;
            this.fname = fName;
            this.lname = lName;
            this.phoneN = pHoneN;
            this.email= email;
        }
        public ToolsAction(string marka, string tipus, string tartozek, bool repairNew, string megjegyzes, 
            string fName, string lName, string pHoneN, string email)
        {
            this.dateid = DateTime.Now;
            this.marka = marka;
            this.tipus = tipus;
            this.tartozek = tartozek;
            this.hordozhato = false;
            this.repairNew= repairNew;
            this.megjegyzes = megjegyzes;
            this.fname = fName;
            this.lname = lName;
            this.phoneN = pHoneN;
            this.email= email;
        }
        public ToolsAction(string marka, string tipus, string tartozek,string megjegyzes, string fName, string lName, string pHoneN, string email)
        {
            this.dateid = DateTime.Now;
            this.marka = marka;
            this.tipus = tipus;
            this.tartozek = tartozek;
            this.hordozhato = false;
            this.repairNew= false;
            this.megjegyzes = megjegyzes;
            this.fname = fName;
            this.lname = lName;
            this.phoneN = pHoneN;
            this.email= email;
        }
        public ToolsAction(string marka, string tipus, string tartozek, bool hordozhato, bool repairNew, string megjegyzes, string fName, string lName)
        {
            this.dateid = DateTime.Now;
            this.marka = marka;
            this.tipus = tipus;
            this.tartozek = tartozek;
            this.hordozhato = hordozhato;
            this.repairNew= repairNew;
            this.megjegyzes = megjegyzes;
            this.fname = fName;
            this.lname = lName;
            this.phoneN = "Nem adott meg telefonszámot";
            this.email= "Nem adott meg email címet";
        }
        public override string ToString()
        {
            return string.Format
                (
                dateid.ToString("dd MMMM yyyy HH:mm:ss"),
                marka,
                tipus,
                tartozek,
                hordozhato ? "Hordozható" : "Nem_hordozhato",
                repairNew ? "Javítás":"Megrendelés",
                megjegyzes,
                fname,
                lname,
                phoneN,
                email
                );
        }
        


    }
}
