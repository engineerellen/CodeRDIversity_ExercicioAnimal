using Domain;
using Microsoft.AspNetCore.Mvc;


namespace AnimalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumansController : ControllerBase
    {
        private List<Humano> lstHumanos;

        public HumansController()
        {
            var bebe = new Humano(1, "Noah", 0, ETipoIdade.mes);
            var adultoHomemCis = new Humano(2, "Ricardo", 35, ETipoIdade.ano);

            lstHumanos = new List<Humano>() { bebe, adultoHomemCis };
        }

        [HttpGet]
        public IEnumerable<Humano> Get() => lstHumanos;


        [HttpGet("{id}")]
        public Humano Get(int id)
        {
            foreach (var humano in lstHumanos)
            {
                if (humano.ID == id)
                    return humano;
            }
            return new Humano(0, string.Empty, 0, ETipoIdade.ano);
        }


        [HttpPost]
        public List<Humano> Post([FromBody] Humano humano)
        {
            lstHumanos.Add(humano);

            return lstHumanos;
        }

        [HttpPut("{id}")]
        public List<Humano> Put(int id, [FromBody] string nome)
        {
            foreach (var humano in lstHumanos)
            {
                if (humano.ID == id)
                    humano.Nome = nome;
            }

            return lstHumanos;
        }

        [HttpDelete("{id}")]
        public List<Humano> Delete(int id)
        {
            try
            {
                foreach (var humano in lstHumanos)
                {
                    if (humano.ID == id)
                    {
                        lstHumanos.Remove(humano);
                        break;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return lstHumanos;
        }
    }
}