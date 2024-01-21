using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    internal class Målinger : Lokale
    {
        protected int _idd;
        DateTime _date;
        private double _temp;
        private int _Co2;
        private int _AntalPersoner;

        public int Id 
        { 
            get { return _idd; } 
            set { _idd = value; }
        }
        public DateTime Date 
        { 
            get { return _date; } 
            set { _date = value; }
        }
        public double Temp
        { 
            get { return _temp; } 
            set { _temp = value; }
        }

        public int CO2 
        { 
            get { return _Co2; } 
            set { _Co2 = value; }
        }

        public int Personer
        {
            get { return _AntalPersoner; }
            set { _AntalPersoner = value; }
        }


        public Målinger()
        {
            _idd =0;
            _date = DateTime.Now;
            _temp = 0;
            _Co2 = 0;
            _AntalPersoner = 0;

        }

        public Målinger(int id, DateTime date, int temp, int Co2, int antalpersoner, Lokale lokale)
        {
            _idd = id;
            _date = date;
            _temp=temp;
            _Co2 = Co2;
            _AntalPersoner=antalpersoner;
            _lokaleNumber = lokale.LokaleNumber;
            _maxAntalPersoner = lokale.MaxAntalPersoner;


        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Date)}={Date.ToString()}, {nameof(Temp)}={Temp.ToString()}, {nameof(CO2)}={CO2.ToString()}, {nameof(Personer)}={Personer.ToString()}, {nameof(ID)}={ID.ToString()}, {nameof(LokaleNumber)}={LokaleNumber}, {nameof(MaxAntalPersoner)}={MaxAntalPersoner.ToString()}}}";
        }
    }
}
