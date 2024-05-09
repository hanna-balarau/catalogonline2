using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogonline
{
    internal class date
    {
        string nume, prenume, mama, tata, clasa, email,litera,cnp;
        int telefon,zi,an,luna;
        public string getNume()
        { 
            return nume;

        }
        public void setNume(string n)
        {
            nume = n;

        }
        public string getPren()
        {
            
            return prenume;

        }
        public void setPren(string pr)
        {
            prenume = pr;

        }
        public string getMama()
        {
           
            return mama;

        }
        public void setMama(string m)
        {
            mama = m;
        }
        public string getTata()
        {
           
            return tata;

        }
        public void setTata(string t)
        {
            tata = t;

        }
        public int getTel()
        {
            
            return telefon;

        }
        public void setTel(int tel)
        {
            telefon = tel;

        }
        public string getClasa()
        {
           
            return clasa;

        }
        public void setClasa(string cls)
        {
            clasa = cls;

        }
        public string getlitera()
        {
            
            return litera;

        }
        public void setlitera(string lit)
        {
            litera = lit ;

        }
        public string getMail()
        {
           
            return email;

        }
        public void setMail(string ml)
        {
            email = ml;

        }

        public string getcnp()
        {
          
            return cnp;

        }
        public void setcnp(string c)
        {
            cnp = c;

        }
    }
    
}
