using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealityFirst.Models;
using System.Data.SqlClient;
using RealityFirst.Servicio.Contrato;

namespace RealityFirst.Servicio
{
    public class EventoServicio : IServicio<Evento>
    {
        private string Connection;
        public EventoServicio(string ConnectionString)
        {
            this.Connection = ConnectionString;
        }

        public void Create(Evento obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Evento Get(int id)
        {
            Evento evento = new Evento();

            using (SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();
                string query = string.Format(
                    "Select a.id, a.nombre, a.fotoURL, a.Descripcion, a.Fecha, a.Lugar, b.nombre from evento a join artista b on (a.artista = b.id);"
                    );
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            evento = new Evento()
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                fotoURL = reader.GetString(2),
                                Descripcion = reader.GetString(3),
                                Fecha = reader.GetDateTime(4),
                                Lugar = reader.GetString(5),
                                Artista = reader.GetString(6)

                            };
                        }
                    }
                }
                server.Close();
            }
            return evento;
        }

        public IList<Evento> GetAll()
        {
            IList <Evento> lista = new List<Evento>();

            using (SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();
                string query = string.Format(
                    "Select a.id, a.nombre, a.fotoURL, a.Descripcion, a.Fecha_hora, a.Lugar, b.nombre from evento a join artista b on (a.artista = b.id);"
                    );
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Evento()
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                fotoURL = reader.GetString(2),
                                Descripcion = reader.GetString(3),
                                Fecha = reader.GetDateTime(4),
                                Lugar = reader.GetString(5),
                                Artista = reader.GetString(6)
                            });
                        }
                    }
                }
                server.Close();
            }
                return lista;
        }

        public void Update(Evento obj)
        {
            throw new NotImplementedException();
        }

        public IList<Evento> FiltrarPorArtista(string artista)
        {
            IList<Evento> lista = this.GetAll();
            return lista.Where(x => x.Artista == artista).ToList();
        }
    }
}
