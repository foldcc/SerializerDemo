using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SerializationDemo.Serialize;
using SerializationDemo.Serialize.SerializeHandler;

namespace SerializationDemo
{

    [Serializable]
    public class Person
    {
        [NonSerialized]
        public List<int> Infos;
        
        public string Name;
        private int Age;
        protected int ID;

        public Person(string rName , int rAge, int rId)
        {
            this.Name = rName;
            this.Age = rAge;
            this.ID = rId;
        }

        public void PrintInfo(string fristStr)
        {
            Console.WriteLine($"{fristStr} Name: {this.Name} , Age: {this.Age} , ID: {this.ID} , infosLength: {this.Infos?.Count ?? 0}");
        }
    }

    internal class SerializationMain
    {
        public static void Main(string[] args)
        {
            
            
            var mPerson = new Person("张三" , 18 , 123456);
            mPerson.Infos = new List<int>{1,5,6,8,3};
//            mPerson.PrintInfo("序列化之前");
//
//            using (FileStream fs = new FileStream(@"..\1.byte" , FileMode.OpenOrCreate , FileAccess.Write))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                bf.Serialize(fs , mPerson);
//            }
//
//            using (FileStream fs = new FileStream(@"..\1.byte" , FileMode.OpenOrCreate , FileAccess.Read))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                var mP = (Person)bf.Deserialize(fs);
//                mP.PrintInfo("反序列化");
//            }
            
            

            Console.ReadKey();
        }
        
        
    }
}