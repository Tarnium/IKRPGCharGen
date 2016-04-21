namespace IKRPGCharGen
{
    internal class Stat
    {
        string name { get; set; }
        int value { get; set; }

        Stat()
        {
            this.name = null;
            value = 0;
        }

        Stat(string name,int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}