//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Security.AccessControl;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.Script.Serialization;

//namespace Automapper
//{
//    class QueryString
//    {
//        public string Name { get; set; }
//        public string Value { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            var inputval = "year: 1, Field: 1";

//            var list = inputval.Split(',')
//                .Select(p =>
//                {
//                    var kv = p.Split(':');
//                    return new KeyValuePair<int, string>(int.Parse(kv[0].Trim()), kv[1]);
//                })
//                .ToList();

//            var input = "Name=Irwin&Home=Caribbean&Preference=Coffee";
//            var items = input.Split(new[] { '&' });
//            var dict = items.Select(item => item.Split(new[] { '=' })).ToDictionary(pair => pair[0], pair => pair[1]);

//            foreach (var item in list)
//            {
//                if (item.Value == "1")
//                {
//                    var FieldName = item.Key;
//                    var FieldValue = string.Empty;
//                    foreach (var QueryValue in dict)
//                    {
//                        if (QueryValue.Key == "FieldName")
//                        {
//                            FieldValue = QueryValue.Value;
//                        }
//                    }
//                }
//            }

//            string jsonFilePath = @"C:\MyFolder\myFile.json";

//            var str = "{ key1: value1, key2: value2}";

//            Dictionary<string, object> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(jsonFilePath);



//            //SaveVehicle obj = new SaveVehicle(new Vehilce());
//            //obj.SaveData();
//            //Console.ReadKey();

//            //SaveStore objStore = new SaveStore(new Store());
//            //objStore.SaveData();
//            //Console.ReadKey();
//        }


//    }

//    public interface ISave
//    {
//        void showData();
//    }
//    class Vehilce : ISave
//    {
//        public string Key = "Vehicle";
//        public void showData()
//        {
//            Console.Write("Interface A");
//        }
//    }
//    class Store : ISave
//    {
//        public string Key = "Store";
//        public void showData()
//        {
//            Console.Write("Interface B");
//        }
//    }

//    class SaveVehicle : BaseSave<Vehilce>
//    {

//        public void SaveData()
//        {

//            Console.Write("testsave Vehicle");
//            Console.Read();

//        }

//        public SaveVehicle(ISave Repository) : base(Repository)
//        {
//        }
//    }
//    class SaveStore : BaseSave<Store>
//    {

//        //public void SaveData()
//        //{

//        //    Console.Write("testsave store");
//        //    Console.Read();

//        //}

//        public SaveStore(ISave Repository) : base(Repository)
//        {
//        }
//    }

//    internal class BaseSave<T>
//    {
//        private ISave objSave;
//        public BaseSave(ISave Repository)
//        {
//            objSave = Repository;
//        }
//        public void SaveData()
//        {
//            var data = typeof(T);

//            objSave.showData();
//            Console.Write("test");
//            Console.Read();

//        }
//    }




//}
