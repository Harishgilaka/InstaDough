namespace InstaDough.Core.BusinessManager.Exceptions
{
    internal class QueryHandlerNotFoundException : Exception
    {
        private Type type;
        public QueryHandlerNotFoundException() { }
        public QueryHandlerNotFoundException(Type type) { this.type = type; }
        public QueryHandlerNotFoundException(string message) : base(message) { }
        public QueryHandlerNotFoundException(string message, Exception innerException) : base(String.Format(message, innerException)) { }
    }
}
