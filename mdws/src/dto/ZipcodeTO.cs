#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using gov.va.medora.mdo;

namespace gov.va.medora.mdws.dto
{
    public class ZipcodeTO : AbstractTO
    {
        public string code;
        public string city;
        public string state;
        public string stateAbbr;

        public ZipcodeTO() { }

        public ZipcodeTO(Zipcode mdoZip)
        {
            this.code = mdoZip.Code;
            this.city = mdoZip.City;
            this.state = mdoZip.State;
            this.stateAbbr = mdoZip.StateAbbr;
        }
    }
}
