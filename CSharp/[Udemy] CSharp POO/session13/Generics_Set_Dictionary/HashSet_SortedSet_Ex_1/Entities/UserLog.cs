using System.Diagnostics;
using System.Text;

namespace HashSet_SortedSet_Ex_1.Entities
{
    internal class UserLog
    {
        public string Name { get; set; }
        public DateTime AccessTime { get; private set; }

        public UserLog() { }
        public UserLog(string name, DateTime accessTime)
        {
            Name = name;
            AccessTime = accessTime;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not UserLog)
            {
                return false;
            }

            UserLog other = obj as UserLog;

            return Name.Equals(other.Name);
        }
    }
}