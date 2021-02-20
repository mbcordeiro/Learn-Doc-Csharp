using System;
using System.Collections.Generic;
using System.Text;

namespace MixinsWithInterfacesProject.Interfaces
{
    public enum PowerStatus
    {
        NoPower,
        ACPower,
        FullBattery,
        MidBattery,
        LowBattery
    }

    public interface ILight
    {
        void SwitchOn();
        void SwitchOff();
        bool IsOn();
        public PowerStatus Power() => PowerStatus.NoPower;
    }
}
