// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: can_card_parameter.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.canbus
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CANCardParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CANCardParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(CANCardBrand.FAKE_CAN)]
        public CANCardBrand brand
        {
            get { return __pbn__brand ?? CANCardBrand.FAKE_CAN; }
            set { __pbn__brand = value; }
        }
        public bool ShouldSerializebrand()
        {
            return __pbn__brand != null;
        }
        public void Resetbrand()
        {
            __pbn__brand = null;
        }
        private CANCardBrand? __pbn__brand;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(CANCardType.PCI_CARD)]
        public CANCardType type
        {
            get { return __pbn__type ?? CANCardType.PCI_CARD; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private CANCardType? __pbn__type;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(CANChannelId.CHANNEL_ID_ZERO)]
        public CANChannelId channel_id
        {
            get { return __pbn__channel_id ?? CANChannelId.CHANNEL_ID_ZERO; }
            set { __pbn__channel_id = value; }
        }
        public bool ShouldSerializechannel_id()
        {
            return __pbn__channel_id != null;
        }
        public void Resetchannel_id()
        {
            __pbn__channel_id = null;
        }
        private CANChannelId? __pbn__channel_id;

        [global::ProtoBuf.ProtoContract()]
        public enum CANCardBrand
        {
            FAKE_CAN = 0,
            ESD_CAN = 1,
            SOCKET_CAN_RAW = 2,
            HERMES_CAN = 3,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum CANCardType
        {
            PCI_CARD = 0,
            USB_CARD = 1,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum CANChannelId
        {
            CHANNEL_ID_ZERO = 0,
            CHANNEL_ID_ONE = 1,
            CHANNEL_ID_TWO = 2,
            CHANNEL_ID_THREE = 3,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
