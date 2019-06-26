using SerializationDemo.Serialize.SerializeHandler;

namespace SerializationDemo.Serialize
{
    public class SerializeConvert
    {
        private ISerializeHandler mSerializeHandler;
        
        public SerializeConvert(SerializeType rSerializeType)
        {
            switch (rSerializeType)
            {
                case SerializeType.Binary:
                    this.mSerializeHandler = new BinaryHandler();
                    break;
                case SerializeType.XML:
                    this.mSerializeHandler = new XMLHandler();
                    break;
                case SerializeType.JSON:
                    this.mSerializeHandler = new JSONHandler();
                    break;
            }
        }

        public byte[] Serialize(object value)
        {
            return this.mSerializeHandler.Serialize(value);
        }

        public T Deserialize<T>(byte[] data)
        {
            var dataObj = this.mSerializeHandler.Deserialize(data);
            
            return dataObj != null ? (T) dataObj : default(T);
        }

    }
}