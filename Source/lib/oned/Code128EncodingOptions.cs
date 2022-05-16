﻿/*
 * Copyright 2013 ZXing.Net authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.ComponentModel;

using ZXing.Common;

namespace ZXing.OneD
{
    /// <summary>
    /// The class holds the available options for the Code128 1D Writer
    /// </summary>
    [Serializable]
    public class Code128EncodingOptions : EncodingOptions
    {
        /// <summary>
        /// if true, don't switch to codeset C for numbers
        /// </summary>
#if !NETSTANDARD && !NETFX_CORE && !PORTABLE && !UNITY
        [Category("Standard"), Description("If true, don't switch to codeset C for numbers.")]
#endif
        public bool ForceCodesetB
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.CODE128_FORCE_CODESET_B))
                {
                    return (bool)Hints[EncodeHintType.CODE128_FORCE_CODESET_B];
                }
                return false;
            }
            set
            {
                Hints[EncodeHintType.CODE128_FORCE_CODESET_B] = value;
            }
        }
        /// <summary>
        /// Forces which encoding will be used. Currently only used for Code-128 code sets (Type <see cref="System.String" />). Valid values are "A", "B", "C".
        /// </summary>
#if !NETSTANDARD && !NETFX_CORE && !PORTABLE && !UNITY
        [Category("Standard"), Description("Forces which encoding will be used. Valid values are \"A\", \"B\", \"C\".")]
#endif
        public Codesets ForceCodeset
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.FORCE_CODE_SET))
                {
                    return (Codesets)Hints[EncodeHintType.FORCE_CODE_SET];
                }
                return Codesets.None;
            }
            set
            {
                Hints[EncodeHintType.FORCE_CODE_SET] = value;
            }
        }

        /// <summary>
        /// avaiable codesets
        /// </summary>
        public enum Codesets
        {
            /// <summary>
            /// none specified
            /// </summary>
            None = -1,
            /// <summary>
            /// Codeset A
            /// </summary>
            A,
            /// <summary>
            /// Codeset B
            /// </summary>
            B,
            /// <summary>
            /// Codeset C
            /// </summary>
            C
        }
    }
}
