﻿﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Http.Enums
{
    /// <summary>
    /// Source où aller chercher le jeton d'autorisation
    /// </summary>
    public enum JWTAuthorizeTokenSource
    {
        Header = 0,
        Cookies = 1
    }
}