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
using HIS.Desktop.LocalStorage.HisConfig;
using Inventec.Core;
using MOS.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Desktop.LocalStorage.BackendData.Core.CFG
{
    class HisConfigCFG
    {
        internal static bool IsUseZip
        {
            get
            {
                long value = HisConfigs.Get<long>(HisConfigKeys.CONFIG_KEY__HIS_DESKTOP__IS_USE_ZIP);
                return (value == 1);
            }
        }

        internal static bool IsAllowShowingAnapathology
        {
            get
            {
                long value = HisConfigs.Get<long>(HisConfigKeys.CONFIG_KEY__ASSIGN_SERVICE_ALLOW_SHOWING_ANAPATHOGY);
                return (value == 1);
            }
        }

        internal static bool IsUseRedisCacheServer
        {
            get
            {
                long value = HisConfigs.Get<long>(HisConfigKeys.CONFIG_KEY__HIS_IS_USE_REDIS_CACHE_SERVER);
                return (value == 1);
            }
        }
    }
}
