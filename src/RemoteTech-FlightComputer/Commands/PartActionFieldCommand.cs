﻿using System;
using RemoteTech.Common.Utils;

namespace RemoteTech.FlightComputer.Commands
{
    public class PartActionFieldCommand : AbstractCommand
    {
        [Persistent]
        public UIPartActionFieldItem FieldItem;

        public override string Description => ShortName + Environment.NewLine + base.Description;

        public override string ShortName => "Toggle field " + FieldItem.Field.name;


        public static PartActionFieldCommand FromField(UIPartActionFieldItem fieldItem)
        {
            return new PartActionFieldCommand()
            {
                FieldItem = fieldItem,
                TimeStamp = TimeUtil.GameTime,
            };
        }
    }
}