using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using MLA_task.BLL.Interface;
using MLA_task.BLL.Interface.Exceptions;
using MLA_task.BLL.Interface.Models;
using MLA_task.DAL.Interface;
using MLA_task.DAL.Interface.Entities;

namespace MLA_task.BLL
{
    public class DemoModelService : IDemoModelService
    {
        private readonly IDemoDbModelRepository _demoDbModelRepository;

        public DemoModelService(IDemoDbModelRepository demoDbModelRepository)
        {
            _demoDbModelRepository = demoDbModelRepository;
        }

        public async Task<DemoModel> GetDemoModelByIdAsync(int id)
        {
            if (id == 23)
            {
                throw new DemoServiceException(DemoServiceException.ErrorType.WrongId);
            }

            var dbModel = await _demoDbModelRepository.GetByIdAsync(id);
            var commonInfo = await _demoDbModelRepository.GetCommonInfoByDemoIdAsync(id);

            var demoModel = new DemoModel
            {
                Id = dbModel.Id,
                Name = dbModel.Name,
                Created = dbModel.Created,
                Modified = dbModel.Modified,
                CommonInfo = commonInfo.CommonInfo
            };

            return demoModel;
        }

        /// <summary>
        /// Method GetModelsAsync.
        /// </summary>
        /// <returns> Returns all models.</returns>
        public async Task<IEnumerable<DemoModel>> GetModelsAsync()
        {
            var models = await _demoDbModelRepository.GetDemoDbModelsAsync();

            Mapper.Initialize(cfg => cfg.CreateMap<DemoDbModel, DemoModel>()
            .ForMember("Id", opt => opt.MapFrom(c => c.Id))
            .ForMember("Name", opt => opt.MapFrom(c => c.Name))
            .ForMember("CommonInfo", opt => opt.MapFrom(c => c.DemoCommonInfoModel.CommonInfo)));

            return Mapper.Map<IEnumerable<DemoDbModel>, IEnumerable<DemoModel>>(models);
        }

    }
}
