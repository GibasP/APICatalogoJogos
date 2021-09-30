using System;

namespace APICatalogoJogos.InputModel
{
    internal class StringLenghtAttribute : Attribute
    {
        public StringLenghtAttribute(int v, int MinimumLenght, string ErrorMessage)
        {
            V = v;
            this.MinimumLenght = MinimumLenght;
            this.ErrorMessage = ErrorMessage;
        }

        public int V { get; }
        public int MinimumLenght { get; }
        public string ErrorMessage { get; }
    }
}