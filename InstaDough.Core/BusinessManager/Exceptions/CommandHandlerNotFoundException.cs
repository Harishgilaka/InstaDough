namespace InstaDough.Core.BusinessManager.Exceptions
{
    internal class CommandHandlerNotFoundException : Exception
    {
        private Type type;
        public CommandHandlerNotFoundException() { }
        public CommandHandlerNotFoundException(Type type) { this.type = type; }
        public CommandHandlerNotFoundException(string message) : base(message) { }
        public CommandHandlerNotFoundException(string message, Exception innerException) : base(String.Format(message, innerException)) { }
    }
}
