using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;

namespace SagaMap.Packets.Server
{
    public class SSMG_PLAYER_STATUS_EXTEND : Packet
    {
        public SSMG_PLAYER_STATUS_EXTEND()
        {
            this.data = new byte[63];
            this.offset = 2;
            this.ID = 0x0217;

            this.PutByte(0x1E, 2);
        }

        public ushort Speed
        {
            set
            {
                this.PutUShort(value, 3);
            }
        }

        public ushort ATK1Min
        {
            set
            {
                this.PutUShort(value, 5);
            }
        }

        public ushort ATK2Min
        {
            set
            {
                this.PutUShort(value, 7);
            }
        }

        public ushort ATK3Min
        {
            set
            {
                this.PutUShort(value, 9);
            }
        }

        public ushort ATK1Max
        {
            set
            {
                this.PutUShort(value, 11);
            }
        }

        public ushort ATK2Max
        {
            set
            {
                this.PutUShort(value, 13);
            }
        }

        public ushort ATK3Max
        {
            set
            {
                this.PutUShort(value, 15);
            }
        }

        public ushort MATKMin
        {
            set
            {
                this.PutUShort(value, 17);
            }
        }

        public ushort MATKMax
        {
            set
            {
                this.PutUShort(value, 19);
            }
        }

        public ushort DefBase
        {
            set
            {
                this.PutUShort(value, 21);
            }
        }

        public ushort DefAddition
        {
            set
            {
                this.PutUShort(value, 23);
            }
        }

        public ushort MDefBase
        {
            set
            {
                this.PutUShort(value, 25);
            }
        }

        public ushort MDefAddition
        {
            set
            {
                this.PutUShort(value, 27);
            }
        }

        public ushort HitMelee
        {
            set
            {
                this.PutUShort(value, 29);
            }
        }

        public ushort HitRanged
        {
            set
            {
                this.PutUShort(value, 31);
            }
        }

        public ushort HitMagic
        {
            set
            {
                this.PutUShort(value, 33);
            }
        }

        public ushort HitCritical
        {
            set
            {
                this.PutUShort(value, 35);
            }
        }

        public ushort AvoidMelee
        {
            set
            {
                this.PutUShort(value, 37);
            }
        }

        public ushort AvoidRanged
        {
            set
            {
                this.PutUShort(value, 39);
            }
        }

        public ushort AvoidMagic
        {
            set
            {
                this.PutUShort(value, 41);
            }
        }

        public ushort AvoidCritical
        {
            set
            {
                this.PutUShort(value, 43);
            }
        }

        public ushort HealHP
        {
            set
            {
                this.PutUShort(value, 45);
            }
        }

        public ushort HealMP
        {
            set
            {
                this.PutUShort(value, 47);
            }
        }

        public ushort HealSP
        {
            set
            {
                this.PutUShort(value, 49);
            }
        }

        public ushort ASPD
        {
            set
            {
                this.PutUShort(value, 51);
            }
        }

        public ushort CSPD
        {
            set
            {
                this.PutUShort(value, 53);
            }
        }
    }
}
        
