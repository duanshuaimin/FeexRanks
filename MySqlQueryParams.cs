namespace Freenex.FeexRanks
{
    public class MySqlQueryParams
    {
        public string ParamName;
        public object ParamValue;

        public MySqlQueryParams(string name, object value)
        {
            ParamName = name;
            ParamValue = value;
        }
    }
}