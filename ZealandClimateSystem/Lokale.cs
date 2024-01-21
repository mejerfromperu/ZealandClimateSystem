using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    internal class Lokale
    {
        protected int _id = 1;
        protected string _lokaleNumber;
        protected int _maxAntalPersoner;


        public int ID
        { get { return _id; } set {  _id = value; } }

        public string LokaleNumber
        { 
            get { return _lokaleNumber;}
            set { _lokaleNumber = value; }
        }

        public int MaxAntalPersoner
        {
            get { return _maxAntalPersoner; }
            set { _maxAntalPersoner = value; }

        }

        public Lokale()
        {
            _id++;
            _lokaleNumber= string.Empty;
            _maxAntalPersoner = 0;
        }

        public Lokale(string lokalenumber, int maxantalperson)
        {
            _id++;
            _lokaleNumber = lokalenumber;
            _maxAntalPersoner=maxantalperson;
        }

        public override string ToString()
        {
            return $"{{{nameof(ID)}={ID.ToString()}, {nameof(LokaleNumber)}={LokaleNumber}, {nameof(MaxAntalPersoner)}={MaxAntalPersoner.ToString()}}}";
        }
    }
}
