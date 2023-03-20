﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Application.Features.UserSettings.Command.GetUserSettingValue
{
    public class GetUserSettingResponse
    {
        public int Id { get; set; }
        public int SettingId { get; set; }
        public int UserId { get; set; }
        public string SelectedValue { get; set; }
        public int Sequence { get; set; }
        public bool IsAdded { get; set; }
        public string Route { get; set; }

    }
}
