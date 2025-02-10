namespace Interfaces_Heranca_Multipla.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);
    }
}
