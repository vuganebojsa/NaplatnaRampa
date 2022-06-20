using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.DTOs;
using TurnpikeGate.Core.TollStations.Repository;

namespace TurnpikeGate.Core.TollStations.Service
{
    public class TollStationService : ITollStationService
    {
        private ITollStationRepository _tollStationRepository;

        public TollStationService(ITollStationRepository tollStationRepository)
        {
            _tollStationRepository = tollStationRepository;
        }

        public void Delete(string id)
        {
            _tollStationRepository.Delete(ObjectId.Parse(id));

        }

        public List<TollStation> GetAll()
        {
            return _tollStationRepository.GetAll();
        }

        public TollStation GetById(ObjectId id)
        {
            return _tollStationRepository.GetById(id);
        }

        public void Insert(CreateTollStationDTO tollStationDTO)
        {
            _tollStationRepository.Insert(ParseToEntity(tollStationDTO));
        }

        public static TollStation ParseToEntity(CreateTollStationDTO tollStationDTO)
        {
            return new TollStation
            {
                Address = tollStationDTO.Address,
                Name = tollStationDTO.Name,
                ReferentIds = tollStationDTO.ReferentIds,
                LocationId = tollStationDTO.LocationId,
                StationManagerId = tollStationDTO.StationManagerId,
                TollBoothIds = tollStationDTO.TollBoothIds
            };
        }

        public void Update(TollStation entity)
        {
            _tollStationRepository.Update(entity);
        }
    }
}
