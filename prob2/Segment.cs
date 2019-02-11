using System;
using System.Collections.Generic;
using System.Text;

namespace prob2
{
    public class Segment
    {
        public double Start { get; set; }
        public double End { get; set; }

        public Segment(double start, double end)
        {
            Start = start;
            End = end;
        }

        public bool Contains(Segment segment)
        {
            bool rezultat = Start <= segment.Start && End >= segment.End;

            return rezultat;
        }

        public RelativePosition GetRelativePosition(Segment segment)
        {
            RelativePosition result = RelativePosition.Unknown;

            if (segment.End < Start)
            {
                result = RelativePosition.Before;
            }

            else if (segment.Start > End)
            {
                result = RelativePosition.After;
            }

            else
            {
                result = RelativePosition.Unknown;
            }

            return result;
        }

        public RelativePosition GetRelativePosition2(Segment segment)
        {
            if (segment.End < Start)
            {
                return RelativePosition.Before;
            }

            if (segment.Start > End)
            {
                return RelativePosition.After;
            }

            return RelativePosition.Unknown;
        }
    }
}
