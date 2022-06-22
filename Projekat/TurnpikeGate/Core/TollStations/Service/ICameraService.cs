﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.Service
{
    public interface ICameraService
    {
        public List<Camera> GetAll();
        void Insert(Camera camera);
    }
}