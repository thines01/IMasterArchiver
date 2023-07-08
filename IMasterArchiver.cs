namespace IMasterArchiver
{
   public interface IMasterArchiver<T> where T : class
   {
      bool Load(T master, ref string strError);
      bool Store(T master, ref string strError);
   }
}