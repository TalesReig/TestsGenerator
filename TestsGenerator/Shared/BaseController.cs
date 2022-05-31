namespace TestsGenerator.Shared
{
    public abstract class BaseController
    {
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract UserControl GetControl();
    }
}