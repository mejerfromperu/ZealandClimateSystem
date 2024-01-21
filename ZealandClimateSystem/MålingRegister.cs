using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    internal class MålingRegister
    {

        private List<Målinger> _liste;
        public DateTime datetime;
        public int AntalUlovlige = 0;
        private List<Målinger> _resultatliste = new List<Målinger>();

        public MålingRegister()
        {
            _liste = new List<Målinger>();

        }

        


        // Metoder

        public void Add(Målinger m)
        {
            if(m.CO2 <= 1000)
            {
                _liste.Add(m);
                Console.WriteLine($"The current time the object was added was: {DateTime.Now}");
            }
            else
            {
                _liste.Add(m);
                Console.WriteLine($"The current time the object was added was: {DateTime.Now}");
                AntalUlovlige++;
            }    
        }

        public void Remove(Målinger m)
        {
            _liste.Remove(m);

        }

        public void Clear()
        {
            _liste.Clear();
        }

        public List<Målinger> GetAll()
        {
            return _liste;
        }

        public Målinger GetMåling(int id)
        {
            var foundmåling = _liste.FirstOrDefault(k => k.Id == id);

            if (foundmåling != null)
            {
                return foundmåling;
            }

            else
            {
                return null;

            }
                
        }

        public List<Målinger> AlleTempUnderOver(int min, int max)
        {
            List<Målinger> resultatliste = new List<Målinger>();

            for (int i = 0; i < _liste.Count; i++)
            {
                if (_liste[i].Temp >= min && _liste[i].Temp <= max)
                {
                    resultatliste.Add(_liste[i]);
                }
            }
            return resultatliste;
        }





        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
