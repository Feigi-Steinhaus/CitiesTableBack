using Bll.Services;
using Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private CityBll Bll;
        public CityController(CityBll bll)
        {
            this.Bll = bll;
        }
        [HttpGet]
        public async Task<List<Dal.Models.City>> GetAsync()
        {
            return await Bll.GetAsync();
        }

        [HttpPost]
        public async Task<Dal.Models.City> CreateAsync([FromQuery(Name = "name")] string item)
        {
            return await Bll.CreateAsync(item);
        }
        [HttpDelete]
        public async Task<bool> DeleteAsync([FromQuery(Name = "id")] int id)
        {
            return await Bll.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<bool> UpdateAsync([FromBody]City item)
        {
            return await Bll.UpdateAsync(item);
        }
    }
}
