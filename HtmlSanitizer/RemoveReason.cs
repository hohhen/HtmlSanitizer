﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganss.XSS
{
    /// <summary>
    /// List of reasons why something was identified to get removed from the HTML
    /// </summary>
    public enum RemoveReason
    {
        /// <summary>
        /// Tag is not allowed
        /// </summary>
        NotAllowedTag,
        /// <summary>
        /// Attribute is not allowed
        /// </summary>
        NotAllowedAttribute,
        /// <summary>
        /// Style is not allowed
        /// </summary>
        NotAllowedStyle,
        /// <summary>
        /// Value is a not allowed or harmful url
        /// </summary>
        NotAllowedUrlValue,
        /// <summary>
        /// Value is not allowed or harmful
        /// </summary>
        NotAllowedValue,
    }
}
