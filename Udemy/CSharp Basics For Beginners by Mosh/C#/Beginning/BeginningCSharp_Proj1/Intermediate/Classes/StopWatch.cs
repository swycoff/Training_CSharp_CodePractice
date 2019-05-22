using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate {
    class StopWatch {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running; //defaults to false

        public TimeSpan Duration {
            get {
                if (_startTime == null && _stopTime == null) {
                    throw new InvalidOperationException();
                }
                    TimeSpan durationTimeSpan = _stopTime - _startTime;
                    //each time duration is checked we reset stop and start time.
                    _stopTime = new DateTime(); 
                    _startTime = new DateTime();
                    return durationTimeSpan;                                 
            }
        }
        //public DateTime StartTime {
        //    get { return _startTime; }
        //    set {_startTime = value;  }
        //}
        //public DateTime StopTime { get { return _stopTime; } set { _stopTime = value; } }

        public void Start() {
            //Do validation at the beginning of a method
            if (_running) {
                throw new InvalidOperationException("Stopwatch is already running.");
            } 
                _startTime = DateTime.Now;
                _running = true;                
            
            //if (_startTime == default(DateTime)) {
            //    StartTime = DateTime.Now;
            //} else {
            //    throw new InvalidOperationException();
            //}            
        }
        public TimeSpan Stop() {
            if (!_running) {
                throw new InvalidOperationException("Stopwwatch is not running.");
            }
            _stopTime = DateTime.Now;
            _running = false;
            return Duration;
        }
        
    }
}
