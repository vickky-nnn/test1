namespace FortCodeExercises.Exercise1
{
    public class Machine
    {
        
        public int _type = 0;
        public int Type
        {
            get => _type;
            set { _type = value; }
        }
        private bool _hasMaxSpeed = true;
        private int _absoluteMax, _max;

        private string _machineName = "";
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_machineName))
                {
                    switch (_type)
                    {
                        case 2:
                            _machineName = "tractor";
                            break;
                        case 0:
                            _machineName = "bulldozer";
                            break;
                        case 1:
                            _machineName = "crane";
                            break;
                        case 4:
                            _machineName = "car";
                            break;
                        case 3:
                            _machineName = "truck";
                            break;
                        default:
                            break;
                    }
                }
                return _machineName;
            }
        }

        private string _description = "";
        public string Description
        {
            get
            {
                _hasMaxSpeed = _type == 3 ? _hasMaxSpeed = false
                    : _type == 1 ? _hasMaxSpeed = true
                    : _type == 2 ? _hasMaxSpeed = true
                    : _type == 4 ? _hasMaxSpeed = false : _hasMaxSpeed;
                _description += $" {Color} {Name} [{GetMaxSpeed(_type, _hasMaxSpeed)}].";
                return _description;
            }
        }

        private string _color = "white";
        public string Color
        {
            get
            {
                _color = _type == 1 ? "blue" 
                    : _type == 0 ? "red"
                    : _type == 4 ? "brown"
                    : _type == 3 ? "yellow"
                    : _type == 2 ? "green" : "white";
                return _color;
            }
        }

        private string _baseColor = "white";
        private string _trimColor = "";
        private bool _isDarkTemp;
        public string TrimColor
        {
            get
            {
                if (_type == 0) _baseColor = "red";
                else if (_type == 1) _baseColor = "blue";
                else if (_type == 2) _baseColor = "green";
                else if (_type == 3) _baseColor = "yellow";
                else if (_type == 4) _baseColor = "brown";
                else _baseColor = "white";

                _isDarkTemp = IsDark(_baseColor);
                if (_type == 1 && _isDarkTemp) _trimColor = "black";
                else if (_type == 1 && !_isDarkTemp) _trimColor = "white";
                else if (_type == 2 && _isDarkTemp) _trimColor = "gold";
                else if (_type == 3 && _isDarkTemp) _trimColor = "silver";
                return _trimColor;
            }
        }

        private bool _isDark = false;
        public bool IsDark(string color)
        {
            if (color == "red") _isDark = true;
            else if (color == "yellow") _isDark = false;
            else if (color == "green") _isDark = true;
            else if (color == "black") _isDark = true;
            else if (color == "white") _isDark = false;
            else if (color == "beige") _isDark = false;
            else if (color == "babyblue") _isDark = false;
            else if (color == "crimson") _isDark = true;
            return _isDark;
        }
        
        public int GetMaxSpeed(int machineType, bool noMax = false) {
            _absoluteMax = _max = 70;
            if (machineType == 1 && noMax == false) _max = 70;
            else if (noMax == false && machineType == 2) _max = 60;
            else if (machineType == 0 && noMax == true) _max = 80;
            else if (machineType == 2 && noMax == true) _max = 90;
            else if (machineType == 4 && noMax == true) _max = 90;
            else if (machineType == 1 && noMax == true) _max = 75;
            return _max;
        }
    }
}