using Points;
using System;
using System.Collections.Generic;

namespace _02_Statick_Members_and_Namespaces
{
    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path
        {
            get { return this.path; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Path cannot be null");
                }
                this.path = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            if (point == null)
            {
                throw new ArgumentNullException("Point cannot be null");
            }
            this.Path.Add(point);
        }

        public override string ToString()
        {
            return string.Format("{0}", string.Join("\n", Path));
        }
    }
}