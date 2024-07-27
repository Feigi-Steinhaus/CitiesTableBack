using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class CityDal
    {
        private CitiesContext Db;
        public CityDal(CitiesContext db)
        {
            this.Db = db;
        }


        public async Task<List<Dal.Models.City>> GetAsync()
        {
            try
            {
                return await Db.Cities.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Dal.Models.City>> GetSortAsync()
        {
            try
            {
                return await Db.Cities.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Dal.Models.City> CreateAsync(string item)
        {
            try
            {
                var city = new City { Name = item };
                await Db.Cities.AddAsync(city);
                await Db.SaveChangesAsync();
                return city;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                Dal.Models.City item = await Db.Cities.FirstOrDefaultAsync(o => o.Id == id);
                Db.Cities.Remove(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<bool> UpdateAsync(Dal.Models.City item)
        {
            try
            {
                var data = await Db.Cities.FirstOrDefaultAsync(x => x.Id == item.Id);
                if (data != null)
                {
                    data.Name = item.Name;
                    await Db.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
