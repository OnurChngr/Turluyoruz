using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabaaClass
{
    class araba
    {
        public string model;      
        public int hiz,yil;
        string marka,plaka;


        public araba()
        {
            hiz = 0;
        }
        public string Marka
        {
            get { return marka; }
            set
            {             
                
                    marka = value;
                
            }
        
        }

        public string Plaka
        {
            get { return plaka; }
            set
            {
                if (value.Length>=5)
                {
                    plaka = value;
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("lütfen geçerli bir değer giriniz");
                }
            }
        
        }

        public int Hizlan()
        {
            hiz = hiz + 50;
            return hiz;
        }
        public int Yavasla()
        {
            hiz = hiz - 25;
            return hiz;
        }









    }
}
