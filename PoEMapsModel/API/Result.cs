namespace PoEMapsModel.API
{
    public class ResultModel
    {
        public string[] result { get; set; }
        public string id { get; set; }
        public int total { get; set; }

        public ResultModel()
        {
            result = new string[200];
        }
    }
}
