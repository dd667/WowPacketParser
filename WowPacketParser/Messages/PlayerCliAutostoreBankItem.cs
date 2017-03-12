using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct PlayerCliAutostoreBankItem
    {
        public InvUpdate Inv;
        public byte Slot;
        public byte PackSlot;
    }
}