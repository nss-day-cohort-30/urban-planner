using System;

namespace Planner {
    public class Building  {

        private string _designer = "Steve Brownlee";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        private double _width;


        public double Width {
            get {
                return _width;
            }

            set {
                if (value > 10) {
                    _width = value;
                }
            }
        }

        public double Depth { get; set; }
        public int Stories { get; set; }
        public double Volume {
            get {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building (string address) {
            _address = address;
        }

        public Building Construct () {
            _dateConstructed = DateTime.Now;
            return this;
        }

        public Building Purchase (string purchaser) {
            _owner = purchaser;
            return this;
        }

        public override string ToString () {
            return $@"
{_address}
-------------------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space.";
        }
    }
}