using System;

namespace project.Servis
{
    internal class ConsoleTable
    {
        private string v1;
        private string v2;
        private string v3;

        public ConsoleTable(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal void AddRow(object no, object name, object p)
        {
            throw new NotImplementedException();
        }

        internal void AddRow(int no, string name)
        {
            throw new NotImplementedException();
        }

        internal void Write()
        {
            throw new NotImplementedException();
        }
    }
}