﻿using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class RoomViewModel
    {
        public IEnumerable<Room> rooms { get; set; }
    }
}
