using AppGetJsonDemo.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppGetJsonDemo.ViewModel
{
    public class ListagemViewModel
    {
        const string URL_GET_DATA = "https://api.jsonbin.io/b/5fda99b487c5307111d4d224";
        public ObservableCollection<Data> Datas { get; set; }

        public ListagemViewModel()
        {
            this.Datas = new ObservableCollection<Data>();
        }

        public async Task GetDatas()
        {
            HttpClient client = new HttpClient();
            var resultado = await client.GetStringAsync(URL_GET_DATA);
            var datasJson = JsonConvert.DeserializeObject<DataJson[]>(resultado);

            foreach (var dataJson in datasJson)
            {
                this.Datas.Add(new Data
                {
                    WaterFlow = dataJson.waterFlow,
                    Date = dataJson.date
                });
            }
        }
        class DataJson
        {
            public int waterFlow { get; set; }
            public string date { get; set; }
        }
    }
}
