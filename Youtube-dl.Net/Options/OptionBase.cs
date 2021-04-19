namespace YoutubeDl
{
    public abstract class OptionBase : IYdlOption
    {
        protected string key;

        public override int GetHashCode() => key.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is OptionBase other)
                return key.Equals(other.key);
            return false;
        }
    }
}
