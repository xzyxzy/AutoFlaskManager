﻿using System.Collections.Generic;

namespace FlaskManager
{
    class FlaskInformation
    {
        public Dictionary<string, FlaskAction> UniqueFlaskNames { get; set; }
        public Dictionary<string, FlaskAction> FlaskTypes { get; set; }
        public Dictionary<string, FlaskAction> FlaskMods { get; set; }
    }
}
