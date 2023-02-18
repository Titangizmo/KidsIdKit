﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsIdKit.Data
{
    /// <summary>
    /// Maps to identity principal provided by credentials provider.
    // TODO : Elaborate for token management, sessions, issuer URI, timestamp last verified, etc.
    /// </summary>
    public class UserIdentity
    {
        public string ProviderName { get; set; }
        public string UserIdFromProvider { get; set; }
    }
}
