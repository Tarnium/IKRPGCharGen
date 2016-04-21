namespace IKRPGCharGen
{
    public class InvItem
    {
        public string name { get; set; }
        public string desc { get; set; }
        public int amount { get; set; }

        InvItem(string name,string desc,int amount)
        {
            this.name = name;
            this.desc = desc;
            this.amount = amount;
        }
    }
}