using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealityFirst.Models;
using System.Data.SqlClient;
using RealityFirst.Servicio.Contrato;

namespace RealityFirst.Servicio
{
    public class NoticiaServicio : IServicio<Noticia>
    {
        private string Connection;
        public NoticiaServicio(string ConnectionString)
        {
            this.Connection = ConnectionString;
        }
        public void Create(Noticia obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Noticia Get(int id)
        {
            Noticia noticia = new Noticia();
            using (SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();
                string query = string.Format(
                    "select id, titulo, subtitulo, imagen, cuerpo, escritor from noticias where id = {0};",id
                    );
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            noticia = new Noticia()
                            { 
                                Id = reader.GetInt32(0),
                                titulo = reader.GetString(1),
                                subtitulo = reader.GetString(2),
                                imagen = reader.GetString(3),
                                cuerpo = reader.GetString(4),
                                escritor = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
            return noticia;
        }

        public IList<Noticia> GetAll()
        {
            IList<Noticia> lista = new List<Noticia>();
            using (SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();
                string query = string.Format(
                    "select id, titulo, subtitulo, imagen, cuerpo, escritor from noticias;"
                    );
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Noticia()
                            {
                                Id = reader.GetInt32(0),
                                titulo = reader.GetString(1),
                                subtitulo = reader.GetString(2),
                                imagen = reader.GetString(3),
                                cuerpo = reader.GetString(4),
                                escritor = reader.GetString(5)
                            });
                        }
                    }
                }
                server.Close();
            }
            return lista;
        }

        public void Update(Noticia obj)
        {
            throw new NotImplementedException();
        }
    }
}

