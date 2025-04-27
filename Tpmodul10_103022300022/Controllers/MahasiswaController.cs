using Microsoft.AspNetCore.Mvc;

namespace Tpmodul10_103022300022.Controllers
{
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Nadya Aulia Salma", "103022300022"),
            new Mahasiswa("Deswita Syaharani", "103022300004"),
            new Mahasiswa("Apriliani", "103022300054"),
            new Mahasiswa("Aisyah", "103022300114"),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}