namespace BrokenLid
{
    public class BrokenClass
    {
        public void SomeChildCodeIsBroken()
        {
            throw new InvalidOperationException("errrr the library crashed!");
        }
    }
}
