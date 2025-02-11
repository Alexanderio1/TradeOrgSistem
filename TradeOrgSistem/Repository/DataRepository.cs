using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Repository
{
    public class DataRepository
    {
        private static DataRepository _instance;
        private static readonly object _lock = new object();
        private const string FilePath = "data.json";

        public DataRoot Data { get; private set; }

        private DataRepository()
        {
            LoadData();
        }

        public static DataRepository Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataRepository();
                    }
                    return _instance;
                }
            }
        }

        public void LoadData()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var json = File.ReadAllText(FilePath);
                    Data = JsonConvert.DeserializeObject<DataRoot>(json) ?? new DataRoot();
                }

                catch(Exception ex)
                {
                    throw new ApplicationException("Ошибка при загрузке данных из файла JSON.", ex);
                }
            }
            else
            {
                Data = new DataRoot();
            }
        }

        public void SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(Data, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }

            catch(Exception ex)
            {
                throw new ApplicationException("Ошибка при сохранении данных в файл JSON.", ex);
            }
        }
    }
}
