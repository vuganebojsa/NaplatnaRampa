using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Repository;

namespace TurnpikeGate.Core.TollStations.Service
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository _cameraRepository;

        public CameraService(ICameraRepository cameraRepository)
        {
            _cameraRepository = cameraRepository;
        }

        public void Delete(string id)
        {
            _cameraRepository.Delete(ObjectId.Parse(id));

        }

        public List<Camera> GetAll()
        {
            return _cameraRepository.GetAll();
        }

        public Camera GetById(ObjectId id)
        {
            return _cameraRepository.GetById(id);
        }

        public void Insert(Camera cameraId)
        {
            _cameraRepository.Insert(cameraId);
        }

        public void Update(Camera entity)
        {
            _cameraRepository.Update(entity);
        }
    }
}
