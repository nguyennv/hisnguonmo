/* IVT
 * @Project : hisnguonmo
 * Copyright (C) 2017 INVENTEC
 *  
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 *  
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Desktop.Plugins.HisBank
{
    public class HisRequestUriStore
    {
        internal const string HIS_BANK_CREATE = "/api/HisBank/Create";
        internal const string HIS_BANK_DELETE = "/api/HisBank/Delete";
        internal const string HIS_BANK_UPDATE = "/api/HisBank/Update";
        internal const string HIS_BANK_GET = "/api/HisBank/Get";
        internal const string HIS_BANK_CHANGE_LOCK = "/api/HisBank/ChangeLock";
    }
}
