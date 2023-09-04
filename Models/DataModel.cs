using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED2_20230828.Models
{
    internal class DataModel
    {
        private int _dia;
        private int _mes;
        private int _ano;

        public int Dia { get { return _dia; } }
        public int Mes { get { return _mes; } }
        public int Ano { get { return _ano; } }

        public DataModel(int dia, int mes, int ano) 
        { 
            _dia = dia; _mes = mes; _ano = ano;
        }

        public DataModel()
        {
            _dia = 1; _mes = 1; _ano = 1;
        }

        public void setData(int dia, int mes,int ano)
        {
            _dia = dia; _mes= mes; _ano = ano;
        }

        public override string? ToString()
        {
            return $"{_dia}/{_mes}/{_ano}";
        }
    }
}
