namespace graphics
{
    public class Point3D
    {
        int x, y, z;

        public Point3D(int _x,int _y,int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        
        //default construcotr
        public Point3D():this(0,0,0) //ctor chaining
        {

        }
        //copy construcotr
        public Point3D(Point3D copiedPoint3D)
        {
            x = copiedPoint3D.x;
            y = copiedPoint3D.y;
            z = copiedPoint3D.z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        //override (string) casting  from Point3d to string
        public static implicit operator string(Point3D P)
        {
            return P.ToString();
        }

        //override Equal function
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point3D p = (Point3D)obj; //cast object to point3D
                return (x == p.x) && (y == p.y) && (z == p.z);
            }
        }
        

    }
}