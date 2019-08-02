namespace StrategyPattern_EncodingStrategyDemo
{
    /// <summary>
    /// IStrategy interface
    /// </summary>
    public interface IEncodingStrategy
    {
        void EncodeValue(string value);
    }
}