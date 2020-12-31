﻿using Farmino.Data.Models.Aggregations;
using Farmino.Service.Exceptions;
using Farmino.Service.Extensions;
using Farmino.Service.Repositories.Interfaces;
using Farmino.Service.Service.Interfaces;
using System.Threading.Tasks;

namespace Farmino.Service.Service
{
    public class FarmerService : IFarmerService
    {
        private readonly IUserRepository _userRepository;
        private readonly IFarmerRepository _farmerRepository;

        public FarmerService(IUserRepository userRepository, 
            IFarmerRepository farmerRepository)
        {
            _userRepository = userRepository;
            _farmerRepository = farmerRepository;
        }

        public async Task CreateFarmer(string userName)
        {
            if(await _userRepository.IsUserExist(userName))
            {
                var user = await _userRepository.GetAsync(userName);

                if(!await _farmerRepository.IsFarmerExist(userName))
                {
                    await _farmerRepository.AddAsync(new Farmer(user));
                    await _farmerRepository.SaveAsync();
                }
                else throw new ServiceExceptions(ServiceErrorCodes.FarmerAlreadyExist,
                    "Farmer with this login already exist");
            }
            else throw new ServiceExceptions(ServiceErrorCodes.UserAlreadyExist,
                $"User with login { userName } dont exist");
        }
    }
}
