namespace YoutubeDl.Options
{
    public abstract class YdlOptionBase : IYdlOption
    {
        protected string key;

        public override int GetHashCode() => key.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is YdlOptionBase other)
                return key.Equals(other.key);
            return false;
        }
    }
}
