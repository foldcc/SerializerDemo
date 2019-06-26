using System;

namespace SerializationDemo.Serialize.SerializeHandler
{
    public interface ISerializeHandler
    {
    byte[] Serialize(object SerializeObject);
    object Deserialize(byte[] SerializeData);
    }
}