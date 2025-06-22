namespace FactoryMethodPatternExample
{
    // Creator Abstract Class
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
