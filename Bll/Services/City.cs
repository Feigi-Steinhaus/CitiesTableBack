using Dal.Models;
using Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public class CityBll
    {
        private CityDal Dal;
        public CityBll(CityDal dal)
        {
            this.Dal = dal;
        }


        public async Task<List<City>> GetAsync()
        {
            try
            {
                return await Dal.GetAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<City>> GetSortAsync()
        {
            try
            {
                return await Dal.GetSortAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<City> CreateAsync(string item)
        {
            try
            {
                return await Dal.CreateAsync(item); 
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
                return await Dal.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<bool> UpdateAsync(City item)
        {
            try
            {
                return await Dal.UpdateAsync(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
