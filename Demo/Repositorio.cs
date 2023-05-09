using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Repositorio
    {
        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get { return _agenda.Find<Agenda>(_ => true).ToList<Agenda>(); }
        }

        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://claudio:suamae123456@cluster0.e962m0s.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("apdesktop");
            _agenda = mongoDatabase.GetCollection<Agenda>("Agenda");

        }
    }
   
}

