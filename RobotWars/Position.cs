using System;

namespace RobotWars
{
    public class Position : IEquatable<Position>
    {
        public Orientation Orientation { get; set; }
        public Coordinate Coordinate { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Orientation * 397) ^ Coordinate.GetHashCode();
            }
        }

        public static bool operator ==(Position left, Position right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !Equals(left, right);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position)obj);
        }

        public bool Equals(Position obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Orientation == obj.Orientation && Coordinate.Equals(obj.Coordinate);
        }

        public override string ToString()
        {
            return Coordinate.X + " " + Coordinate.Y + " " + Orientation;
        }
    }
}