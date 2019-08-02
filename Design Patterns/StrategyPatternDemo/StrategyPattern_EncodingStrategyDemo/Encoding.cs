namespace StrategyPattern_EncodingStrategyDemo
{
    /// <summary>
    /// Context class
    /// </summary>
    public class Encoding
    {
        private IEncodingStrategy _encodeStrategy;

        public Encoding(IEncodingStrategy encodeStrategy)
        {
            _encodeStrategy = encodeStrategy;
        }

        public void Encode(string value)
        {
            _encodeStrategy.EncodeValue(value);
        }
    }
}