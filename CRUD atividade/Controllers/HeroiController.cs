using CRUD_atividade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_atividade.Controllers
{
    public class HeroiController : ApiController
    {
        private static List<Heroi> Herois = new List<Heroi>();

        /// <summary>
        /// Retorna todos os heróis
        /// </summary>
        /// <returns>Lista de heróis</returns>
        //Ex.:  GET http://localhost:49310/api/Heroi
        public IEnumerable<Heroi> Get()
        {
            return Herois;
        }

        /// <summary>
        /// Retorna um herói definido por Id
        /// </summary>
        /// <param name="id">id do herói</param>
        /// <returns> Herói pertencente à lista</returns>
        //Ex.: GET http://localhost:49310/api/Heroi/5
        public IEnumerable<Heroi> Get(int id)
        {
            return Herois.Where(x => x.Id == id);
        }

        /// <summary>
        /// Adiciona um herói
        /// </summary>
        /// <param name="value">atributos do herói</param>
        //Ex.: POST http://localhost:49310/api/Heroi
        public void Post([FromBody]Heroi value)
        {
            Herois.Add(value);
        }

        /// <summary>
        /// Atualiza um herói por id
        /// </summary>
        /// <param name="id">id do herói a ser alterado</param>
        /// <param name="value">novos atributos do herói</param>
        //Ex.: PUT http://localhost:49310/api/Heroi/5
        public void Put(int id, [FromBody]Heroi value)
        {
            Herois.RemoveAll(x => x.Id == id);
            Herois.Add(value);
        }

        /// <summary>
        /// Deleta um herói por id
        /// </summary>
        /// <param name="id"></param>
        //Ex.: DELETE http://localhost:49310/api/Heroi/5
        public void Delete(int id)
        {
            Herois.RemoveAll(x => x.Id == id);
        }
    }
}
