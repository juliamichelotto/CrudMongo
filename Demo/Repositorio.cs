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
            get {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>(); }
        }

        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://claudio:suamae123456@cluster0.e962m0s.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("apdesktop");
            _agenda = mongoDatabase.GetCollection<Agenda>("agenda");

        }
    }
   
}

