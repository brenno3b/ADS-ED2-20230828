using ADS_ED2_20230828.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED2_20230828.Controller
{
    internal class ContatosController
    {
        private readonly List<ContatoModel> _agenda;

        public List<ContatoModel> Agenda { get {  return _agenda; } }

        public ContatosController(List<ContatoModel> agenda)
        {
            _agenda = agenda;
        }

        public ContatosController()
        {
            _agenda = new List<ContatoModel>();
        }

        public bool Adicionar(ContatoModel c)
        {
            bool alreadyExists = _agenda.Any(e => e.Email == c.Email);

            if (alreadyExists) return false;

            _agenda.Add(c);

            return true;
        }

        public ContatoModel Pesquisar(ContatoModel c)
        {
            int index = _agenda.FindIndex(e => e.Email == c.Email);

            if (index == -1) return new ContatoModel();

            return _agenda[index];
        }

        public bool Alterar(ContatoModel c)
        {
            int index = _agenda.FindIndex(e => e.Email == c.Email);

            if (index == -1) return false;

            _agenda[index] = c;

            return true;
        }

        public bool Remover(ContatoModel c)
        {
            int index = _agenda.FindIndex(e => e.Email == c.Email);

            if (index == -1) return false;

            _agenda.RemoveAt(index);

            return true;
        }
    }
}
