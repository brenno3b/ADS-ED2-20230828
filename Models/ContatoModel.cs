using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED2_20230828.Models
{
#pragma warning disable CS0659 // O tipo substitui Object. Equals (objeto o), mas não substitui o Object.GetHashCode()
    internal class ContatoModel
#pragma warning restore CS0659 // O tipo substitui Object. Equals (objeto o), mas não substitui o Object.GetHashCode()
    {
        // E-mail será o meu "ID".
        private readonly string _email;
        private readonly string _nome;
        private readonly DataModel _dtNasc;
        private readonly List<TelefoneModel> _telefones;

        public string Email { get { return _email; } }
        public string Nome { get { return _nome; } }
        public DataModel Data { get { return _dtNasc; } }
        public List<TelefoneModel> Telefones { get { return _telefones; } }

        public ContatoModel(string email, string nome, DataModel dtNasc, List<TelefoneModel> telefones)
        {
            _email = email; _nome = nome; _dtNasc = dtNasc; _telefones = telefones;
        }

        public ContatoModel(string email)
        {
            _email = email; _nome = ""; _dtNasc = new DataModel(); _telefones = new List<TelefoneModel>();
        }

        public ContatoModel()
        {
            _email = ""; _nome = ""; _dtNasc = new DataModel(); _telefones = new List<TelefoneModel>();
        }

        public int GetIdade()
        {
            return 2023 - _dtNasc.Ano;
        }

        public void AdicionarTelefone(TelefoneModel t)
        {
            _telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            if (_telefones.Count == 0) return "";

            int i = 0;

            while (i < _telefones.Count && !_telefones[i].Principal)
            {
                i++;
            }

            if (i < _telefones.Count) return _telefones[i].Numero;

            return "";
        }
        public override string? ToString()
        {
            return $"Email: {_email}, Nome: {_nome}, DtNasc: {_dtNasc}, Telefone principal: {GetTelefonePrincipal()}";
        }

        public override bool Equals(object? obj)
        {
            return obj is ContatoModel model &&
                   _email == model._email &&
                   _nome == model._nome &&
                   EqualityComparer<DataModel>.Default.Equals(_dtNasc, model._dtNasc) &&
                   EqualityComparer<List<TelefoneModel>>.Default.Equals(_telefones, model._telefones);
        }
    }
}
