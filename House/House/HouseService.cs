using System;
using System.Collections.Generic;
using House.DataAccess;
using House.Models;

namespace House.BusinessLogic
{
    /// <summary>
    /// Сервис для работы с домами
    /// </summary>
    public class HouseService
    {
        private readonly HouseRepository _houseRepository;
        private readonly ResidentialComplexRepository _complexRepository;

        public HouseService()
        {
            _houseRepository = new HouseRepository();
            _complexRepository = new ResidentialComplexRepository();
        }

        public List<HouseModel> GetHouses(int? complexId = null, string addressFilter = null)
        {
            return _houseRepository.GetAll(complexId, addressFilter);
        }

        public HouseModel GetHouseById(int id)
        {
            return _houseRepository.GetById(id);
        }

        public List<ResidentialComplex> GetAllResidentialComplexes()
        {
            return _complexRepository.GetAll();
        }

        public void CreateHouse(HouseModel house)
        {
            ValidateHouse(house);
            _houseRepository.Create(house);
        }

        public void UpdateHouse(HouseModel house)
        {
            ValidateHouse(house);
            _houseRepository.Update(house);
        }

        public void DeleteHouse(int id)
        {
            _houseRepository.Delete(id);
        }

        private void ValidateHouse(HouseModel house)
        {
            if (house.ResidentialComplexId <= 0)
            {
                throw new ArgumentException("Необходимо выбрать жилищный комплекс.");
            }

            if (string.IsNullOrWhiteSpace(house.Street))
            {
                throw new ArgumentException("Необходимо указать улицу.");
            }

            if (string.IsNullOrWhiteSpace(house.HouseNumber))
            {
                throw new ArgumentException("Необходимо указать номер дома.");
            }

            if (house.HouseCostCoefficient < 0)
            {
                throw new ArgumentException("Добавочная стоимость не может быть отрицательной.");
            }

            if (house.ConstructionCost < 0)
            {
                throw new ArgumentException("Затраты на строительство не могут быть отрицательными.");
            }
        }
    }
}
