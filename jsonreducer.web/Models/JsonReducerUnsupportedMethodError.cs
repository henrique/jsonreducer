namespace jsonreducer.web.Models
{
    public class JsonReducerUnsupportedMethodError
    {
        public string Error
        {
            get
            {
                return "This service only supports POST. Checkout https://github.com/jfbourke/jsonreducer for more.";
            }
        }
    }
}