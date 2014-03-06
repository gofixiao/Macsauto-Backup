namespace Macsauto.Infrastructure.Connector.SmartCard.Reader
{
    using System;

    public static class APDUCommands
    {
        public static byte[] GetControl()
        {
            return new byte[] {0xFF, 0x00, 0x00, 0x00, 0x0A, 0xD4, 0x56, 0x01, 0x02, 0x01, 0x00, 0xFF, 0x00, 0x00};
        }

        public static byte[] GetFirmware()
        {
            return new byte[] {0xFF, 0x00, 0x48, 0x00, 0x00};
        }

        public static byte[] GetPICCParams()
        {
            return new byte[] {0xFF, 0x00, 0x50, 0x00, 0x00 };
        }

        public static byte[] GetBlockValue(int block)
        {
            return new byte[] {0xFF, 0xB0, 0x00, (byte)block, 0x10};
        }

        public static byte[] SetBlockValue(int block, string value)
        {
            var bytes = new byte[] {0xFF, 0xD6, 0x00, (byte) block, 0x10};

            Array.Resize(ref bytes, bytes.Length + value.Length);

            for (int i = 0; i < value.Length ; i++)
            {
                bytes[i + 5] = (byte) value[i];
            }

            return bytes;
        }

        public static byte[] GetIntValue(int block)
        {
            return new byte[] {0xFF, 0xB0, 0x00, (byte) block, 0x00};
        }

        public static byte[] AuthenticateBlock(int block)
        {
            return new byte[] {0xFF, 0x86, 0x00, 0x00, 0x05, 0x01, 0x00, (byte) block, 0x60, 0x01};
        }

        public static byte[] SetPICCParams(PICCParams piccParams)
        {
            return piccParams.GetParams();
        }
    }

    public class PICCParams
    {
        private byte[] _params = new byte[] { 0xFF, 0x00, 0x51, 0x00, 0x00 };

        public byte[] GetParams()
        {
            return _params;
        }

        public PICCParams DetectISO14443TypeACard()
        {
            _params[3] = (byte) (_params[3] | 0x01);

            return this;
        }

        public PICCParams DetectISO14443TypeBCard()
        {
            _params[3] = (byte)(_params[3] | 0x02);

            return this;
        }

        public PICCParams DetectTopazCard()
        {
            _params[3] = (byte)(_params[3] | 0x04);

            return this;
        }

        public PICCParams DetectFeliCa212KCard()
        {
            _params[3] = (byte)(_params[3] | 0x08);

            return this;
        }

        public PICCParams DetectFeliCa424KCard()
        {
            _params[3] = (byte)(_params[3] | 0x10);

            return this;
        }

        public PICCParams SetPollInterval250()
        {
            _params[3] = (byte) (_params[3] | 0x20);

            return this;
        }

        public PICCParams EnableAutomaticATSGeneration()
        {
            _params[3] = (byte)(_params[3] | 0x40);

            return this;
        }

        public PICCParams EnableAutomaticPICCPolling()
        {
            _params[3] = (byte)(_params[3] | 0x80);

            return this;
        }
    }
}